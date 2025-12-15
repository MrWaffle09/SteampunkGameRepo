
# Description
##The game is about a group of four cute robots that have to find the exit of the building they are trapped in before they run out of energy. Players have to navigate the levels and balance getting powerups and looking for the exit of the level.

# A list of the 'requirements from a hat' that you implemented
##The requirements from a hat are: Mana/Energy Bar, Charcater Selector, Steampunk Theme, and Target Audience of Elemantary School Students

# Instructions on how to test each of the chosen features and where to find the related scenes and scripts for each feature
##Mana/Energy Bar: To test this require you just have to run the game and watch it tick down as time passes. In the editor, it can be found in the player scenes (the child classes of Player) and the code can be found under their individual scripts near the bottom.
##Charcter Selctor: This can also be tested just from playing the game. In the editor, it can bee scene under the chracter_selctor scene and script, aswell as in the GameManager global script.
##Steampunk Theme: This can be test from looking at the game: In the editor, related files can be found under the entire asset folder aswell as in the TileMap Layers and the Player scenes.
##Target Audience of Elementary School Students: This can also be tested just from playing the game. All parts of the game relate to this because the simple gameplay and bright colors are all built with Elemtary Schoolers in mind, but you could also look at the Assets again or the ExampleLevel and Levl2 scenes.

# OOP + Godot Features

##There is a abstract class and a child class. If you're looking to find them, go to the player scripts where you will find it under Player.CS. Bulldozer.CS, Mechanic.CS, Capybara.CS, and Microwave.CS are all children of this class.
##There is the private method SpeedUp in the Capybara.cs script and a private variable "steam". There is a private method and variable in Bulldozer.cs as well.
##"is" is used in SpeedUp1.cs to check if something is a player. It is also used in WinScreen.cs to check if @event is a Joypad Button.
##We have Instantiate in ExampleLevel.cs to tell Godot they new node will be a Player.
##The Enum can be found in the GameManager and is used at the tops of the SpeedUp1, SpeedUp2, and SpeedUp3 scripts.
##A custom signal can be found in CustonSignal.cs and is used in the SpeedUp scripts and in the player scripts to connect the power up to the players gaining speed.
##A packed scene can be found in ExampleLevel.cs and is used to instantiate players.
##The _Ready() function can be found in all children of the Player Abstract Class (e.g. Bulldozer.cs).
##The custom controller inputs can be found under project settings.
##A scene change can be found in MainMenu.cs

# Everyone's Contributions

##JP: Example Level 
##Isaiah (Coder): Basic Enemy, Energy Bar, Level 2, Main Menu, Sound Menu
##Garrett (Coder + Assistant): Players, Character Selector, Energy Bar, Lose Screen, Pauser, Speed Ups, Win Screen, Custom Signals, ReadMe 

# Files

##All files are stored in Godot
