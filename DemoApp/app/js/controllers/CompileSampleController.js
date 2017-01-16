'use strict'

eventsApp.controller('CompileSampleController',
  function CompileSampleController($scope, $compile, $parse){

    var fn = $parse('1 + 2');
    console.log(fn());

    throw { message: 'error message'};

    $scope.appendDivToElement = function(markup){
      return $compile(markup)($scope).appendTo(angular.element('#appendHere'));
    };

});
