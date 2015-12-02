'use strict';
app.controller('loginController', function ($scope, $http) {
    $scope.invalidLogin = false;

    // koristi servise i rute MOLIM TE
    $scope.login = function () {
        $http.get("http://localhost:60126/api/Users?email=" + $scope.email + "&password=" + $scope.password)
        .then(function (response) {
            $scope.user = response.data;
            $scope.invalidLogin = $scope.user != null;
        });
    }
});