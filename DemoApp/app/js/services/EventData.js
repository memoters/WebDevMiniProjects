eventsApp.factory('eventData', function($resource){

var resource = $resource('/data/event/:id', {id:'@id'});
  return {
    getEvent: function(eventId){
      // return $http({method: 'GET', url: '/data/event/1'});
      return resource.get({id:eventId});
    },
    save: function(event){
      event.id = 999;
      return resource.save(event);
    },
    getAllEvents: function(){
      return resource.query();
    }
    // event: {
    //     name: 'Angular bootcamp',
    //     date: 1359781015626,
    //     time: '10:04 am',
    //     location: {
    //       address: 'Nonato Residences',
    //       city: 'Sydney',
    //       province: 'NSW'
    //     },
    //     imageUrl: '/img/angularjs-logo.png',
    //     sessions: [
    //       {
    //         name: 'Directives Masterclass',
    //         creatorName: 'Joe Nonato',
    //         duration: 1,
    //         level: 'Advanced',
    //         abstract: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec est nisi, faucibus sit amet fringilla non, finibus sed tellus. Etiam tellus lorem, ullamcorper id arcu vel, lobortis tincidunt metus. Nam laoreet mauris a sodales aliquam. ',
    //         upVoteCount: 0
    //       },
    //       {
    //         name: 'Scopes for fun and profit',
    //         creatorName: 'Recel Jimenez',
    //         duration: 2,
    //         level: 'Introductory',
    //         abstract: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec est nisi, faucibus sit amet fringilla non, finibus sed tellus. Etiam tellus lorem, ullamcorper id arcu vel, lobortis tincidunt metus. Nam laoreet mauris a sodales aliquam. ',
    //         upVoteCount: 0
    //       },
    //       {
    //         name: 'Well behaved controllers',
    //         creatorName: 'Joe Nonato',
    //         duration: 4,
    //         level: 'Intermediate',
    //         abstract: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec est nisi, faucibus sit amet fringilla non, finibus sed tellus. Etiam tellus lorem, ullamcorper id arcu vel, lobortis tincidunt metus. Nam laoreet mauris a sodales aliquam. ',
    //         upVoteCount: 0
    //       }
    //     ]
    //   }
  };
});
