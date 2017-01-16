'user strict'

describe('EventListController', function(){

var $controllerConsctructor, mockEventData;
var scope;
  beforeEach(module("eventsApp"));

  beforeEach(inject(function($controller, $rootScope){
    $controllerConsctructor = $controller;
    scope = $rootScope.$new();
    mockEventData = sinon.stub({getAllEvents: function(){}})
  }));

  it('should set the scope events to the result of eventData.getAllEvents', function(){
    var mockEvents = {};
    mockEventData.getAllEvents.returns(mockEvents);

    $controllerConsctructor("EventListController",
  {'$scope':scope, eventData:mockEventData})
    expect(scope.events).toBe(mockEvents);
  })
});
