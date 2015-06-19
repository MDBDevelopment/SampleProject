main = (function () {
    var loginSuccess = function () {
        window.location.href = '/transactions/';
    };

    var logoutSuccess = function () {
        window.location.href = '/';
    };

    var loginFailure = function () {
        $('#loginFailed').removeClass('invisible');
    };

    var submitLogin = function (email, password) {
        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            url: "/auth/login",
            data: "{Email: '" + email + "', Password: '" + password + "'}",
            success: function (data) {
                if (data != null && data) {
                    loginSuccess();
                } else {
                    loginFailure();
                }
            },
            error: function () {
                loginFailure();
            }
        });
    };

    var submitLogout = function () {
        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            url: "/auth/logout",
            success: function (data) {
                logoutSuccess();
            }
        });
    };

    return {
        login: function () {
            if (!$('#loginForm').valid())
                return;

            var email = $('#Email').val(),
                password = $('#Password').val(),
                $loginFailed = $('#loginFailed');

            if (!$loginFailed.hasClass('invisible'))
                $loginFailed.addClass('invisible')

            submitLogin(email, password);

            return false;
        },
        logout: function () {
            submitLogout();

            return false;
        }
    };
})();