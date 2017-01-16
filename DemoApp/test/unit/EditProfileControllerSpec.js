'use strict'

describe('EditProfileController', function(){
  var $controllerConsctructor, mockGravatarUrlBuilder;
  var scope;
    beforeEach(module("eventsApp"));

    beforeEach(inject(function($controller, $rootScope){
      $controllerConsctructor = $controller;
      scope = $rootScope.$new();
      mockGravatarUrlBuilder = sinon.stub({buildGravatarUrl: function(){}})
    }));

    it('should build the gravatar with the given email address',function(){
      $controllerConsctructor("EditProfileController",
      { '$scope': scope, gravatarUrlBuilder: mockGravatarUrlBuilder});

      var email = "joe@joe.com";

      scope.getGravatarUrl(email);

      expect(mockGravatarUrlBuilder.buildGravatarUrl.calledWith(email)).toBe(true);
    })

});
