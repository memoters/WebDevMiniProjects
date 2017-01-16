'use strict'

eventsApp.directive('greeting', function(){
  return {
    restrict: 'E',
    template: "<img />",
    replace: true,
    priority: 1,
    template: "<button class='btn' ng-click='sayHello()'>Say Hello</button>",
    controller: function($scope){
      var greetings = ['hello'];
      $scope.sayHello = function(){
        alert(greetings.join());
      }
      this.addGreeting = function(greeting){
        greetings.push(greeting);
      }
    }

  };
})
.directive('finnish', function(){
  return {
    restrict: 'A',
    require: 'greeting',
    priority: 1,
    link: function(scope, element, attrs, controller){
      controller.addGreeting('hei');
    }
  }
})
.directive('hindi', function(){
  return{
    restrict: 'A',
    require: 'greeting',
    priority: 2,
    link: function(scope, element, attrs, controller){
      controller.addGreeting('namaste');
    }
  }
});

eventsApp.controller('GreetingController',
function GreetingController($scope){
  $scope.sayHello = function(){
    alert('Hello, bitches!')
  }
});
