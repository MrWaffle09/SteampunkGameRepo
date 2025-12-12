using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class WinMover : Area2D
{
    private void _on_body_entered(Node2D body)
    {
        if (body is Player)
        {
            GD.Print("onLevelMover");
            GetTree().ChangeSceneToFile("res://Scenes/win_screen.tscn");
        }
    }
}
