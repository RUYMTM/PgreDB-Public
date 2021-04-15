function enableEdit() {
    $(".form-control").show();
    $(".view").hide();
    $(":submit").show();
    $(":button").hide();
}
function disableEdit() {
    $(".form-control").hide();
    $(".view").show();
    $(":submit").hide();
    $(":button").show();
}