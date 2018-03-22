var app = angular.module("AdminCV", ["ui.router","720kb.datepicker"]);

app.config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("/home");
    $stateProvider
        .state("home",
        {
            url: "/home",
            templateUrl: "/Client/components/adminCv/templates/home.html",
            controller: ""
        })
         .state("workExperience",
            {
                url: "/workExperience",
                templateUrl: "/Client/components/adminCv/templates/workExperience.html",
                controller: "WorkExperienceController"
            });


}]);