'use strict';

eventsApp.controller('EventController',
function EventController($scope, eventData, $log, $anchorScroll, $routeParams, $route){

  $scope.sortorder = 'name'
  $scope.event = $route.current.locals.event;
  //$scope.event = eventData.getEvent($routeParams.eventId);
  $scope.reload = function(){
    $route.reload();
  }
    // .$promise
    // .then(function(event) { $scope.event = event; console.log(event); })
    // .catch(function(response) { console.log(response); }
    // );

  // eventData.getEvent()
  //   .success(function(event) {$scope.event = event; })
  //   .error(function(data, status, headers, config){
  //     $log.warn(data, status, headers(), config);
  //   })


    $scope.upVoteSession = function(session){
      session.upVoteCount++;
    };

    $scope.downVoteSession = function(session){
      session.upVoteCount--;
    };

    $scope.scrollToSession = function(){
      $anchorScroll();
    };
  }
);
