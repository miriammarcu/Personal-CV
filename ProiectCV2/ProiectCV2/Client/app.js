var app = angular.module("ProiectCV2", ["ui.router", "toaster", "ngAnimate"]);

app.config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise("/info");

    $stateProvider
        .state("info",
        {
            url: "/info",
            templateUrl: "/Client/components/cv/info.html",
            controller: "InfoController"
        })
        .state("education",
        {
            url: "/education",
            templateUrl: "/Client/components/cv/education.html",
            controller: "InfoController"
        })
        .state("work",
        {
            url: "/work",
            templateUrl: "/Client/components/cv/workexp.html",
            controller: "InfoController"
        })
        .state("personalskills",
        {
            url: "/personalskills",
            templateUrl: "/Client/components/cv/personalskills.html",
            controller: "InfoController"
        })
        .state("languages",
        {
            url: "/languages",
            templateUrl: "/Client/components/cv/languages.html",
            controller: "InfoController"
        });
}]);