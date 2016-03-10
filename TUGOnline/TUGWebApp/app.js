var app = angular.module("TUGApp", ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider.when('/customerHome', {
        templateUrl: 'Home/Views/customerHome.html',
        controller: 'customerHomeController'
    })
    .when('/menuItem', {
        templateUrl: 'Home/Views/menuItems.html',
        controller: 'menuItemsController'
    }).
    otherwise({ redirectTo: '/customerHome' });
});

