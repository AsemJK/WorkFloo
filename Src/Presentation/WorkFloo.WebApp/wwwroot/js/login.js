$(function () {

})

function Login() {
    let username = $('#email').val();
    let password = $('#password').val();
    var data = {
        userName: username,
        password: password
    }
    if (data.userName == null || data.password == null) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Something went wrong!',
            footer: '<a href>Why do I have this issue?</a>',
            showConfirmButton: false,
            timer: 1500
        })
    }
    $.ajax({
        type: "POST",
        url: "/api/v1/account/authenticate",
        data: JSON.stringify(data),
        contentType: "application/json",
        success: function (response) {
            if (response.success) {
                localStorage.setItem('token', response.data.token);
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Login Successful, Redirection ....',
                    showConfirmButton: false,
                    timer: 1000
                }).then(
                    () => {
                        window.location.href = "/";
                    }
                );
            } else {
                var errors = response.errors.map(message => message.description);
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: errors,
                    showConfirmButton: false,
                    timer: 1500
                })
            }
        }
        ,
        error: function (response) {
            var errors = response.responseJSON.errors.map(message => message.description);
            Swal.fire
                ({
                    icon: 'error',
                    title: 'Oops...',
                    text: `${errors}`,
                    showConfirmButton: false,
                    timer: 2500
                });

        }
    });

}