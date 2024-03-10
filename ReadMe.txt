For this game of Leap Frog Parkour Masters, I added two platforms at either end of the arena, with one tower in the middle with the biggest obstacle of all, the Spin Log.
The spin log is a deterrant to other players who want to rush their opponent off the bat. The log can be bounced on top of, and if used skillfully, the player bouncing and use it to rack up points against the opponent. The game has potential to be more fun, but these were the added game design tools to improve the game.

February 25, 2024
The changes I made to the game were substantial to the game and fixed many issues
- Fixed the detection of triggers by creating new boxes that hold the triggers and not the actual player colliders.
- Fixed the way the game counts scores so that way the scores don't get counted in twos or a million times.
- Added better UI that reflects the game state and such.
- The points being shown accurately reflect who is scoring the point, no longer will player one score for player 2.

March 3, 2024
The changes that were made was the adding of a manager for player and inventory
-Added a player manager to manage the stats of the player character.
-Added an inventory manager to keep track of picked up items (ie coins).
-Changed the scoring system and interaction of the UI to work through the player manager, calling upon pre-existing methods that increased score.

March 10, 2024
The changes that were made were substantial to how the game is played
-Changed the objective of the second player to collect coins to win the game, while the first player chases them around the arena to jump over them enough times to win.
-The way scoring is done is so that only the second player gets points from the coins, where the first player does not. The first player can still destroy them though.
-Altered the way the player is controlled to allow a more responsive movement system using Rigidbodies.