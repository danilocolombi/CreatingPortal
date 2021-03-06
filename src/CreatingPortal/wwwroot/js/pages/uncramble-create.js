﻿$(".save-button").click(function () {

    Create();
});

function Create() {

    var unscramble = CreateObjectUnscramble();

    if (!ValidateUnscramble(unscramble))
        return;

    $.ajax({
        url: "/Unscramble/Create",
        type: "POST",
        data: JSON.stringify(unscramble),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.error) {
                swal("Ops!", "There was an error while creating your activity. Details: " + response.message, "error");
            }
            else {
                Swal.fire({
                    title: "Good job!", text: "Your unscramble was successfully created", icon: "success"
                }).then(okay => {
                    window.location.href = "/MyActivities";
                });
            }
        }
    });
}