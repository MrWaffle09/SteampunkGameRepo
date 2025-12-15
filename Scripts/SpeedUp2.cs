using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class SpeedUp2 : Area2D
{
    private CustomSignals _customSignals;
    public int SpeedUp = (int)PowerUps.Speed2;

    public override void _Ready()
    {
        _customSignals = GetNode<CustomSignals>("/root/CustomSignals");
    }

    public void _on_body_entered(Node body)
    {
        GD.Print(body);
        if (body is Player player)
        {
            _customSignals.EmitSignal(nameof(CustomSignals.SpeedUp), SpeedUp);
            QueueFree();
        }
        else
        {
            GD.Print("Did not activate speed up.");
            GD.Print(body.GetType());
        }
    }
}


