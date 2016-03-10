app.factory('customerHomeMenuService', ['$http', function ($http) {
    var menuObj = {};
    var urlBase = "http://192.168.1.3/webapi/Api/Product/GetProducts";
    
    menuObj.getMenu = function () {
        return $http.get(urlBase);
    };

    return menuObj;
}]);