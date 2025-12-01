using Godot;
using System;

public partial class Sound : Control
{
	public void OnButtonPressed()
    {
         GetTree().ChangeSceneToFile("res://Scenes/MainMenu.tscn");
    }
}
