using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class LevelMover : Area2D
{
    public void _on_level_mover_body_entered(Node2D body)
    {
        if (body is Player)
        {
            GD.Print("onLevelMover");
            GetTree().ChangeSceneToFile("res://Scenes/level_2.tscn");
        }
    }
}
