var app = angular.module("TUGApp", ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider.when('/customerHome', {
        templateUrl: 'Home/Views/customerHome.html',
        controller: 'customerHomeController'
    }).
    otherwise({ redirectTo: '/customerHome' });
});

