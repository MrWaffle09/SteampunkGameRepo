using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] public int Speed { get; set; } = 400;
    
    
    //Handles Movement
    public void GetInput()
    {
        Vector2 inputDirection = Input.GetVector("MenuLeft", "MenuRight", "MenuUp", "MenuDown");
        Velocity = inputDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }
}
