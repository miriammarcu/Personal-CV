var app = angular.module("AdminCV");
app.controller("WorkExperienceController", ["$scope", "$http", "InfoService", function ($scope, $http, infoService) {
    $scope.startDate = null;
    $scope.endDate = null;
    $scope.workInfo = {};
    $scope.compInfo = {};
    $scope.posInfo = {};
    $scope.ID = null;
    function getWorkExperience()
    {
        infoService.getInfo("getwork").then(function (rsp) {
            $scope.workInfo = rsp.data;
            console.log(rsp);
        }, function (err) {
            console.log("error", "Error", err.message);
        });
    }
    function init()
    {
        getWorkExperience();
        infoService.getInfo("getcomp").then(function (rsp) {
            $scope.compInfo = rsp.data;
            console.log(rsp);
        }, function (err) {
            console.log("error", "Error", err.message);
            });
        infoService.getInfo("getpos").then(function (rsp) {
            $scope.posInfo = rsp.data;
            console.log(rsp);
        }, function (err) {
            console.log("error", "Error", err.message);
        });
    }

    $scope.saveData = function () {
        var data = {
            "ID_WorkExperience" : 0,
            "ID_Company" :$scope.company,
            "ID_Position" :$scope.position,
            "StartDate" : $scope.startDate,
            "EndDate" : $scope.endDate

        };
        infoService.postInfo("savework", data).then(function (rsp) {
            getWorkExperience();
            console.log("Succes", rsp);
        }, function (err) {
            console.log("Eroare", err);
            });
        
    };
    $scope.deleteData = function (ID) {
        infoService.deleteInfo(ID).then(function (rsp) {
            getWorkExperience();
            console.log("Succes", rsp);
        }, function (err) {
            console.log("Eroare", err);
        });
    };
    init();
  
}]);