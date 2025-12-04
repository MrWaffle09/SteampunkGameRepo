using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class SpeedUp1 : Area2D
{
    private void _on_Area2D_body_entered(Node body)
    {
        GD.Print(body);
        if (body is Player)
        {
            Player player = body as Player;
            player.speed += 900000000000;

        }
    }
}


