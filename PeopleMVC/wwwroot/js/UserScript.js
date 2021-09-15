$("#password-repeat").keyup(() => {
    console.log($("#password-repeat").val())
    if ($("#password-repeat").val() !== $("#password").val()) {
        $("#password-msg").html("Passwords do not match!");
        $("#reg-btn").prop("disabled", true);
    } else {
        $("#password-msg").html("");
        $("#reg-btn").prop("disabled", false);
    }
})