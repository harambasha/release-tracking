'use strict';
app.controller('signupController', function ($scope, $http) {
   

    $http.get("http://localhost:60126/api/Roles")
    .then(function (response) {
        $scope.roles = response.data;
    });

    $scope.register = function () {
        var user = {
            FirstName: $scope.firstName,
            LastName: $scope.lastName,
            Email: $scope.email,
            Password: $scope.password,
            RolaId: $scope.selectedRole.Id
        };
        $http.post('http://localhost:60126/api/Users', user);
        res.success(function (data, status, headers, config) {
            $scope.message = data;
        });
        res.error(function (data, status, headers, config) {
            alert("failure message: " + JSON.stringify({ data: data }));
        });
    }
});