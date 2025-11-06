using Godot;
using System;
using Godot.Collections;
using MultiplayerProject.Scripts;

public partial class Player1 : Player
{
    public override int ID { get; set; } = 0;
    public override int speed { get; set; } = 1000;

    public override void Die()
    {
        QueueFree();
    }

    public void _GetInput()
    {
        Vector2 inputDirection = Input.GetVector("MenuLeftP1", "MenuRightP1", "MenuUpP1", "MenuDownP1");
        Velocity = inputDirection * speed;
    }
    
    public override void _PhysicsProcess(double delta)
    {
        _GetInput();
        MoveAndSlide();
    }
}
