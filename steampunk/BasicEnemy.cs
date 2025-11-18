using Godot;
using System;

public partial class basic_enemy : CharacterBody2D
{
    
    public int Speed = 200; // Export speed to easily adjust in the inspector

    private CharacterBody2D player;

   
 public override void _Ready()
    {
        // Find the player node in the scene tree
        
        player = GetTree().GetFirstNodeInGroup("player") as CharacterBody2D; 

        if (player == null)
        {
            GD.PrintErr("Player node not found in 'Player' group!");
        }
    }
    public override void _PhysicsProcess(double delta)
    {
        if (player != null)
        {
           
            Vector2 direction = (player.GlobalPosition - GlobalPosition).Normalized();

            
            Velocity = direction * Speed;

            // Move the enemy
            MoveAndSlide();
            
           
        }
    }
}

