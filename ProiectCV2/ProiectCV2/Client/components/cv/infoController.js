var app = angular.module("ProiectCV2");

app.controller("InfoController", ["$scope", "$http", "InfoService", "toaster", function ($scope, $http, infoService, toaster) {
    $scope.persInfo = {};
    $scope.skillsInfo = {};
    $scope.eduInfo = {};
    $scope.workInfo = {};
    $scope.langInfo = {};
    function init() {
        infoService.getInfo("info").then(function (rsp) {
            $scope.persInfo = rsp.data;
      
            console.log("Pers info", rsp);
        }, function (err) {
            console.log(err);
            toaster.pop("error", "Error", err.data.Message);
            });
        infoService.getInfo("skills").then(function (rsp) {
            $scope.skillsInfo = rsp.data;
            console.log(rsp);
        }, function (err) {
            toaster.pop("error", "Error", err.message);
            });
        infoService.getInfo("lang").then(function (rsp) {
            $scope.langInfo = rsp.data;
           
            console.log(rsp);
        }, function (err) {
            toaster.pop("error", "Error", err.message);
            });
        infoService.getInfo("edu").then(function (rsp) {
            $scope.eduInfo = rsp.data;
            console.log(rsp);
        }, function (err) {
            toaster.pop("error", "Error", err.message);
            });
        infoService.getInfo("work").then(function (rsp) {
            $scope.workInfo = rsp.data;

            console.log(rsp);
        }, function (err) {
            toaster.pop("error", "Error", err.message);
        });
    }

    init();
    
}]);