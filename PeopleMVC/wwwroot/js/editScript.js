let edit = false;

$(".edit-person").hide();

$("#edit-btn").click(() => {

    if (edit) {
        $(this).html = "Edit";
        $(".edit-person").hide();
        $(".person-row").show();
    } else {
        $(this).html = "Exit";
        $(".edit-person").show();
        $(".person-row").hide();
    }
    edit = !edit;
});

