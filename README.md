# Console Based Tic Tac Toe

## Project Description
The program demonstrates a game of Tic Tac Toe in a console application setting, demonstrating a turn-based game.
It has two game modes: Casual and Rush Mode, both having two suboptions: vsBot and Two Player modes.
Player could choose between 3 game layouts: 3x3 (Easy) , 6x6 (Normal) , and 10x10 (Hard).
First game project done by PaulBEureka

### Game Modes
Casual Mode -> No time limit per turn and overall game time limit
Rush Mode -> Has limited time per turn and overall game time limit. Could be adjusted via Settings after logging in

### Game Flow
1. Login or Sign up an account
2. Choose between Casual or Rush Mode
3. Choose between Single Player (vsBot) or Two Player Mode
4. Choose desired difficulty: 3x3 (Easy) , 6x6 (Normal) , and 10x10 (Hard)
5. Roll the dice and see who gets to have the first turn (Dice settings could also be changed before rolling)
6. Instructions would follow before the game starts
7. The player who gets the first turn shall their desired tile number, followed by the second player, and so on in an alternate manner.
8. Whichever side who gets to create a combination wins
9. Program checks if the player who won gets to be in the leaderboard (Excluding bots)

### First Turn Mechanics
The player with the highest value in the rolling of dice would have the first turn.
Sides of the dice could also be adjustd via Settings in the Player Menu or before the game starts

### Leaderboard Mechanics
The top 3 players based on the shortest game time it took them to won. As per general leaderboard functions, it will overwrite existing information if the records are beaten by another player

### Two Player Information
If user chose to have a two player game, another account shall be logged in for the game to commence (Account checking ang leaderboard purposes)

### Bot Information
The Bot turn would be based on random move selection. However, it has an algorithm capabble of detecting if the next turn would result to a row, column, or diagonal combination. In simpler terms, it could block the opponents winning tile or mark the tile the would result to its victory.










