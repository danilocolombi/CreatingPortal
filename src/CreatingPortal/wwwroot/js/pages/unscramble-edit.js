$(".save-button").click(function () {

    Edit();
});

function Edit() {

    var unscramble = CreateObjectUnscramble();

    if (!ValidateUnscramble(unscramble))
        return;

    var unscrambleId = $("#inputUnscrambleId").val();

    $.ajax({
        url: "/Unscramble/Edit/" + unscrambleId,
        type: "PUT",
        data: JSON.stringify(unscramble),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.error) {
                Swal.fire("Ops!", "There was an error while editing your activity. Details: " + response.message, "error");
            }
            else {
                Swal.fire({
                    title: "Good job!", text: "Your unscramble was successfully edited", icon: "success"
                }).then(okay => {
                    window.location.href = "/MyActivities";
                });
            }
        }
    });
}