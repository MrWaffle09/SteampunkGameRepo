using Godot;
using System;



public partial class MainMenu : Control
{

	public void OnPressed() {
		 GetTree().ChangeSceneToFile("res://Scenes/ExampleLevel.tscn");
		
	}
	public void SoundPressed() {
		GetTree().ChangeSceneToFile("res://Scenes/sound.tscn");
		}
}
