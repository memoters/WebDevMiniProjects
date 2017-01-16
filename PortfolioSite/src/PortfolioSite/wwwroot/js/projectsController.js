(function () {
    "use strict";

    angular.module("app-projects")
        .controller("projectsController", projectsController);

    function projectsController($http) {
        var vm = this;

        vm.projects = [];

        vm.errorMessage = "";

        $http.get("/api/projects")
            .then(function (response) {
                //success                                
                angular.copy(response.data, vm.projects);
            },
            function (error) {
                //failure
                vm.errorMessage = "Failed to retrieve projects" + error;

            }).finally(function () {

            });
    }

})();