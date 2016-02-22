app.controller('loginController', ['$scope', function ($scope) {
   
    // function to submit the form after all validation has occurred			
    $scope.login = function () {

        // check to make sure the form is completely valid
        if ($scope.userForm.$valid) {
            //alert($scope.user.Email);
           // $location.path("DashBoard");

        }

    };



}]);