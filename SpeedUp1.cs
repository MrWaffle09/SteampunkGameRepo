using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class SpeedUp1 : Area2D
{
    public void _on_Area2D_body_entered(Node body)
    {
        GD.Print(body);
        if (body is Player player)
        {
            player.speed += (int) PowerUps.Speed1;
            QueueFree();
        }
        else
        {
            GD.Print("Did not activate speed up.");
            GD.Print(body.GetType());
        }
    }
}


