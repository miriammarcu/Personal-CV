var app = angular.module("ProiectCV2");

app.service("InfoService", ["$http", function ($http) {
    var service = {};

    service.getInfo = function (cale) {
        return $http.get("http://localhost:64095/api/" + cale);
    };
    return service;
}]);