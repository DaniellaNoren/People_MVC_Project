$("#password-repeat").focus(() => {
    if ($("#password-repeat").val() == $("#password")) {
        $("#password-msg").html("Passwords do not match!");
        $("#reg-btn").prop("disabled", true);
    } else {
        $("#password-msg").html("");
        $("#reg-btn").prop("disabled", false);
    }
})