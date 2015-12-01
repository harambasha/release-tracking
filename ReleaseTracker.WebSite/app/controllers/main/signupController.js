
var app = angular.module("releaseTrackerApp", []);

app.config(function($stateProvider,$urlRouterProvider){
    $urlRouterProvider.otherwise("/"); //root

    $stateProvider.state('home', {
        url:'/',
        templateUrl: 'app/views/home.html',
        controller: 'homeController'
    });

    $stateProvider.state('login', {
        url:'/login',
        templateUrl: 'app/views/login.html',
        controller: 'loginController'
    });

    $stateProvider.state('signup', {
        url:'/signup',
        templateUrl: 'app/views/signup.html',
        controller: 'signupController'
    });
});