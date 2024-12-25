loginForm.controller("loginFormController", function ($scope, loginFormService) {
    $scope.email = "Email";
    $scope.password = "";
    $scope.page = 0;

    $scope.loginNext = function () {
        console.log($scope.page);
        $scope.page = 1;
    }

    $scope.loginBack = function () {
        $scope.page = 0;
    }
});