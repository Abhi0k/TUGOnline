app.controller('customerController', ['$scope', 'customerHomeMenuService', '$location', function ($scope, customerHomeMenuService, $location) {

    //For hiding navigation items from first menu page
    $scope.location = $location;
    $scope.$watch('location.url()', getTitle);
    function getTitle() {
        $scope.pageTitle = $location.url().substring(1);
    };
    $scope.checkPageTitle = function() {
        if ($scope.pageTitle == 'menuPage')
            return true;
        else
            return false;
    }

    getMenuItems();
    function getMenuItems() {
        customerHomeMenuService.getMenu()
            .success(function (data) {
                $scope.menuItems = data;
            })
            .error(function (error) {
                $scope.status = "error" + error.message;
            });
    };
    
}]);