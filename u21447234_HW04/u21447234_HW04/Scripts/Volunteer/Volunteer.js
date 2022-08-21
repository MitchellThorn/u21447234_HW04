$(document).ready(function () {
    $(".miss").hide();
    $(".tree").hide();
    $(".ocean").hide();

    $("#volType").on("change", function () {
        var val = $(this).val();
        if (val == "1") {
            $(".tree").show();
            $(".miss").hide();
            $(".ocean").hide();
        }
        else
            if (val == "2") {
                $(".ocean").show();
                $(".tree").hide();
                $(".miss").hide();
            }
            else
                if (val == "3") {
                    $(".miss").show();
                    $(".tree").hide();
                    $(".ocean").hide();
                }
    });
})