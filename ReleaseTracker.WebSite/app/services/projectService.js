'use strict';

app.factory("projectService", function ($scope, $http) {
    
    var response = new Object();

    object.AddProject = function () {
        var project = {
            Name: $scope.name,
            Description: $scope.description,
            OwnerId:2 //fiksirano dok ne rijesim autentifikaciju i autorizaciju
        }

        $http.post('http://localhost:60126/api/Projects', project);
        res.success(function (data, status, headers, config) {
            $scope.message = data;
        });
        res.error(function (data, status, headers, config) {
            alert("failure message: " + JSON.stringify({ data: data }));
        });
    }

    return response;

});