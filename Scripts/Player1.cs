using Godot;
using System;
using Godot.Collections;
using MultiplayerInputSharp;
using MultiplayerProject.Scripts;

public partial class Player1 : Player
{
    public override int ID { get; set; } = 0;

    public override void Die()
    {
        QueueFree();
    }

    public void _GetInput()
    {
        Vector2 inputDirection = MultiplayerInput.GetVector(0, "MenuLeft", "MenuUp", "MenuRight", "MenuDown", 1);
        Velocity = inputDirection * speed;
    }
    
    public override void _PhysicsProcess(double delta)
    {
        _GetInput();
    }
}
