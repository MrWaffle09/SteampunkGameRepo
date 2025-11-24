using Godot;
using System;



public partial class MainMenu : Control
{

    public void OnPressed() {
         GetTree().ChangeSceneToFile("res://Scenes/ExampleLevel.tscn");
         GD.Print("Play pressed.");
    }
    public void OnSettingsPressed() {
        
    }

    public void OnExit() {
        
    }
}
