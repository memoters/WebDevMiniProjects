(function () {
    "use strict";

    angular.module('app-projects', ['ngRoute'])
        .config(function ($routeProvider) {

            $routeProvider.when("/", {
                controller: "projectsController",
                controllerAs: "vm",
                templateUrl: "/views/projectsView.html"
            });


            $routeProvider.otherwise({ redirectTo: "/" });

    });

})();