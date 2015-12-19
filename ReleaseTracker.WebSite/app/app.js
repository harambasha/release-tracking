'use strict';

var app = angular.module('releaseTrackingApp', ['ui.router', 'ngResource']);

app.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/');

    $stateProvider.state('home', {
        url: '/',
        templateUrl: 'app/views/home.html',
        controller: 'homeController'
    });

    $stateProvider.state('login', {
        url: '/login',
        templateUrl: 'app/views/login.html',
        controller: 'loginController'
    });

    $stateProvider.state('signup', {
        url: '/signup',
        templateUrl: 'app/views/signup.html',
        controller: 'signupController'
    });

    $stateProvider.state('createProject', {
        url: '/createProject',
        templateUrl: 'app/views/createProject.html',
        controller: 'projectsController'
    });
});