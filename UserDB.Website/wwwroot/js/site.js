// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


window.onload = () => {
    document.getElementById("emailAddress").focus();
};

function save() {
    body = {
        EmailAddress: document.getElementById("emailAddress").value,
        Password: document.getElementById("password").value
    };

    $.ajax({
        url: '/users/save',
        type: 'POST',
        data: JSON.stringify(body),
        contentType: 'application/json',
        dataType: 'json',
        success: (result) => {
            alert ("User Saved");
            document.getElementById("emailAddress").focus();
            document.getElementById("emailAddress").value = '';
            document.getElementById("password").value = '';

        },
        error: (xhr, status, err) => {
            if (xhr.responseJSON && xhr.responseJSON.title) {
                alert (xhr.responseJSON.title)
                if (xhr.responseJSON.errors) {
                    for (const key in xhr.responseJSON.errors) {
                        alert(xhr.responseJSON.errors[key]);
                    }
                }
            } else {
                alert (err || status);
            };
        }
    });
}
