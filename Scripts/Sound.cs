using Godot;
using System;

public partial class Sound : Control
{
    public override void _Ready()
    {
         GetNode<Button>("Back").GrabFocus();
	}
	public void OnButtonPressed()
    {
         GetTree().ChangeSceneToFile("res://Scenes/MainMenu.tscn");
    }
}
