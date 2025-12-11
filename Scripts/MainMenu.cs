using Godot;
using System;



public partial class MainMenu : Control
{
public override void _Ready()
    {
         GetNode<Button>("VBoxContainer/Start").GrabFocus();
	}
	public void OnPressed() {
		 GetTree().ChangeSceneToFile("res://Scenes/ExampleLevel.tscn");
		
	}
	public void SoundPressed() {
		GetTree().ChangeSceneToFile("res://Scenes/sound.tscn");
	}
}

