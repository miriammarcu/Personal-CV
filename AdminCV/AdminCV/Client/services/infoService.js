var app = angular.module("AdminCV");

app.service("InfoService", ["$http", function ($http) {
    var service = {};

    service.getInfo = function (cale) {
        return $http.get("http://localhost:61148/api/" + cale);
    };

    service.postInfo = function (cale, data) {
        return $http.post("http://localhost:61148/api/" + cale, data);
    };
    service.deleteInfo = function (ID) {
        return $http.delete("http://localhost:61148/api/delete?id="+ID);
    };
    return service;
}]);