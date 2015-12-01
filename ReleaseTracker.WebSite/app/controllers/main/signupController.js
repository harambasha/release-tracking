'use strict';
app.controller('signupController', ['$scope', function ($scope,$http) {
   
    $http.get("http://localhost:60126/api/Roles")
    .then(function (response) {
        $scope.roles = response.data.records;
    });


    //var n = [{
    //    Name:"Armin"
    //},
    //{
    //    Name: "Kemila"
    //}
    //];

    //$scope.n = n;
}]);