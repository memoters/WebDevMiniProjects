'use strict'

eventsApp.controller('EventListController',
  function EventListController($scope, eventData){
    $scope.events = eventData.getAllEvents();
    console.log("function finshied: " + eventData.getAllEvents());
  }
);
