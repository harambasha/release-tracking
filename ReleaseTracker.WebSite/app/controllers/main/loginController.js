'use strict';
app.controller('loginController', function ($scope, $http) {
    $scope.valid = true;

    $scope.login = function () {
        var user = new Object();
        $http.get("http://localhost:60126/api/Users?email=" + $scope.email + "&password=" + $scope.password)
        .then(function (response) {
            user = response.data;
        });
        alert(user.Email);
        if (user != null) {
            $scope.valid = true;
        }
        else {
            $scope.valid = false;
        }
    }
});