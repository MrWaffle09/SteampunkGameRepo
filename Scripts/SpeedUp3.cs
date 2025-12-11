using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class SpeedUp3 : Area2D
{
    public void _on_body_entered3(Node body)
    {
        GD.Print(body);
        if (body is Player player)
        {
            player.speed += (int) PowerUps.Speed3;
            QueueFree();
        }
        else
        {
            GD.Print("Did not activate speed up.");
            GD.Print(body.GetType());
        }
    }
}


