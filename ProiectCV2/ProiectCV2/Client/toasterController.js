var app = angular.module("ProiectCV2");

app.controller("ToasterController",["$scope","toaster",function ($scope, toaster) {

    $scope.success = function () {
        toaster.success('Have fun storming the castle!', 'Miracle Max Says');
    };

}]);