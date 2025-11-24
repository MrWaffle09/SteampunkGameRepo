using Godot;
using System;

public partial class BasicEnemy: CharacterBody2D
{
    
    public int Speed = 20; 
    private CharacterBody2D Player;

    

    public void OnPlayerEntered(Node2D node) {
        if (node is CharacterBody2D){
             
            Vector2 direction = (node.GlobalPosition - this.GlobalPosition).Normalized();

            Velocity = direction * Speed;
        
        }
    }
    public override void _PhysicsProcess(double delta) {
        

        MoveAndSlide();
    }
      
    
    public void OnPlayerOut(Node2D node){
      Velocity = Vector2.Zero;
        
    }

}

 
        