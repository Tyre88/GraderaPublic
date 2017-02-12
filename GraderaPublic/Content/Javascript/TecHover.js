$('[hover=true]').live({
    mouseenter: function () {
        var tec = $(this).attr("tec");
        if ($("#hover-" + tec).length <= 0) {

            var pos = $(this).position();
            var style = "style='display: block; position: absolute; min-height: 150px; min-width: 150px; top: " + (pos.top - 75) + "px; left: " + (pos.left + 200) + "px;'";
            var addDiv;

            $.post("/Show/TecImage/", { tec: tec }, function (data) {
                var response = data;

                addDiv = "<div id='hover-" + tec + "' " + style + ">" + response + "</div>";;

                $("body").append(addDiv);
            });
        }
        $("#hover-" + tec).fadeIn(250);
    },
    mouseleave: function () {
        var tec = $(this).attr("tec");
        $("#hover-" + tec).fadeOut(100);
    }
});