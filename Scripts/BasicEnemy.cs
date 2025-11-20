using Godot;
using System;

public partial class BasicEnemy: CharacterBody2D
{
    
    public int Speed = 200; 
    private CharacterBody2D Player;

    

    public void OnPlayerEntered(Node2D node) {
        if (node is CharacterBody2D){
            GD.Print("Body entered"); 
            Vector2 direction = (node.GlobalPosition - this.GlobalPosition).Normalized();

            Velocity = direction * Speed;

        
        }
    }
    public void PhysicsProcess(float delta) {

        MoveAndSlide();
    }


}

 
        