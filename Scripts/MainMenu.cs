using Godot;
using System;



public partial class MainMenu : Control
{
public override void _Ready()
    {
         GetNode<Button>("VBoxContainer/Start").GrabFocus();
	}
	public void OnPressed() {
		 GetTree().ChangeSceneToFile("res://Scenes/character_selector.tscn");
		
	}
	public void SoundPressed() {
		GetTree().ChangeSceneToFile("res://Scenes/sound.tscn");
	}
}

