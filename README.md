# Things in game

* Moving in orbit
* jumping to next orbit
* hp counting in player
* Base logic to put other objects in level, level creation is possible
* ~~retarded~~ code
* Loading next stage(set of objects) when reaching center of orbit
*
## things not working 

* It seems I have angered the Old Ones and now Unity just de-activates the playerOrbiter script when i run the scene. maybe it happens with others aswell i just noticed that one and gave up
* collisions dont really work because movement is done using straight up transform manipulation (apparentely transform.rotateAround does that))
  * a fix could be just put more coliders on sides of player to check if they can move
  * nvm for some reason not even colldiers are recognizing they are inside each other (owo)
* Loading another scene gives some weird ass "not in build index" or smthn error. 
  * of course its not in the build idiot(ie unity engine) i'm running the game in the editor
* Suddenly started getting null exceptions when accessing the levelscript singleton
  * worked in one script didnt work in another
  * fuck me, then it didnt work in both
  * *pushes to repo*
  
## things left to implement

* The code to mine bitcoin from the user's pc while the game is running
* UI
* the actual diferent stuff each non player orbiter object does
  * the player is ready to check for this stuff, providing the forward checker works
 
