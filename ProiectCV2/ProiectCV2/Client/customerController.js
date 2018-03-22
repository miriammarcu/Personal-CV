var app = angular.module("ProiectCV2");

app.controller("CustomersController", ["$scope", "$http", function ($scope, $http) {
    $scope.name = "Daniel";
    $scope.customersList = [];

    $scope.getCustomers = function () {
        console.log("Get customers...");
        $http.get("http://localhost:57036/api/Customers").then(function (rsp) {
            $scope.customersList = rsp.data;
            console.log("Raspuns cu success", rsp);
        }, function (err) {
            console.log("Erroare", err);
        });
    };
}]);
