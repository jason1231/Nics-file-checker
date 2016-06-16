var nfc = (function () {
    var waitTime = 5000;

    //do not edit anything below this line.
    var status =
    {
        Primary: "primary",
        Secondary: "secondary",
        Success: "success",
        Info: "info",
        Warning: "warning",
        Danger: "danger"
    };

    var active = true;

    function addLogEntry(message) {
        var log = $("#log");
        var timestamp = new Date().toLocaleString();
        log.append(timestamp + ": " + message + "<br>");
    }

     function addUrlLogEntry(url)
    {
         addLogEntry('<a href="' + url + '" target="_blank">' + url.split("/").pop() + "</a> has been verified.<br>");
    }

    function go() {
        var csv = $("#csv");

        $.ajax({
            url: "../../Home/Run",
            type: "POST",
            data: {
                 csv: csv.val()
            },
            success: function (response) {
                processResults(response);
            },
            error: function () {
                addLogEntry("Bad request response from server.");
            }
        });
    }

    function processResults(response) {
        response.Messages.forEach(function (message) {
            addLogEntry(message);
        });

        var csv = "";
        var first = true;

        response.Results.forEach(function(result) {
            if (result.FileExists === false) {
                if (first === true) {
                    csv += result.Url;
                    first = false;
                } else {
                    csv += "," + result.Url;
                }
            } else {
                addUrlLogEntry(result.Url);
            }
        });

        if (csv !== "") {
            if (active === true) {
                setTimeout(function() {
                        addLogEntry("Not all files have been verified. Checking again in " + waitTime + " milliseconds.");
                        go();
                    },
                    waitTime);
            } else {
                addLogEntry("Process cancelled by user");
                setStatus("Cancelled", status.Danger);
            }
        } else {
            addLogEntry("Process has successfully completed");
            setStatus("Done", status.Success);
        }
    }

    function setStatus(message, level) {
        var newStatus = $("#status");

        newStatus.html(message);
        newStatus.removeClass();
        newStatus.addClass("label label-" + level);
    }

    $("#start").click(function () {
        addLogEntry("Process started by user.");
        setStatus("Running", status.Success);
        active = true;
        go();
    });

    $("#stop").click(function () {
        addLogEntry("Stopping process.");
        setStatus("Canceling", status.Danger);
        active = false;
    });
})();