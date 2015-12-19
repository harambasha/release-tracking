'use strict';

app.controller('loginController', ['userService','$scope','$http', function ($scope, $http,userService) {
    $scope.invalidLogin = false;
    $scope.login = function () {
        //errori kad pozovem userService..
    }
}]);