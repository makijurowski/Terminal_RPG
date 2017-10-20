# Ideas for Terminal RPG

## **Gameplay**
### **1. Start of Game**
- Player (user) inputs name and selects up to 3 hero companions
- Names for hero companions can be entered or randomized from a name list
- Number of enemies to create varies based on party size
- Player chooses whether to select actions for hero or have them automated
    - Essentially marking the character as player or computer
    - **TO-DO:** Add status to base human class
- Make sure all allies (players + heroes) and enemies are added to their respective lists
- Player chooses how many rounds (e.g. turns) the game should last
    - Options: Short, Normal, Long game

### **2. Turn System**
- Each round, player selects action for themselves (& hero party?)
- Each round, heroes act based on randomized selection or player input
- Each round, enemies attack based on randomizer
    - Targets should be randomized
    - Later add in logic to make enemies "smarter"
- Before turn is over, evaluate status of humans & enemies
    - If HP hits zero, mark character status as K.O. and remove from party


### **3. End of Game**
- Game ends when either all allies or enemies have been defeated
- ASCII art?
- Ask player if they want to play again
    - If yes, restart game
        - Ask to use same or change settings (e.g. turns, characters)
    - If no, thank them for playing

## **General**
### **1. Formatting for Console**
- Keep text aligned for better readability
    - Use loops and conditional statements to align spacing 
- Make sure each turn is clearly demarcated
- Keep DRY principles in mind; use functions to avoid repitition

### **2. Random Thoughts**
- Allow player characters (e.g. controlled by user) to "upgrade" from class Human to one of the hero classes
    - Have the choice triggered by... ?
        - Number of wins
        - Finding a special object (random chance determined each turn)
        - Number of enemies defeated
    - Use current player's info to instantiate a new object with the same arguments passed as parameters