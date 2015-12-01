'use strict';
app.controller('signupController', ['$scope', function ($scope) {
   
    var n = [{
        Name:"Armin"
    },
    {
        Name: "Kemila"
    }
    ];

    $scope.n = n;
}]);