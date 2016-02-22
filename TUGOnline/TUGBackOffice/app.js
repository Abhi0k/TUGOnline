var app = angular.module("TugApp", ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider.when('/login', {
        templateUrl: 'Login/Views/login.html',
        controller: 'loginController'

    }).when('/DashBoard', {
        templateUrl: 'Dashboard/Views/Dashboard.html',
        controller: 'dashBoardController'
    }).
    otherwise({ redirectTo: '/login' });
});