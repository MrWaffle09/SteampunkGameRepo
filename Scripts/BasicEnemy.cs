using Godot;
using System;

public partial class BasicEnemy: CharacterBody2D
{
    //The enemy variables
    public int Speed = 100; 
    private CharacterBody2D Player;
    public int currentHealth = 200;
    public int damage = 100;
// what the enemy is going to do when the player get too close to the area2D
    public void OnPlayerEntered(Node2D node) {
        if (node is CharacterBody2D){
             
            Vector2 direction = (node.GlobalPosition - this.GlobalPosition).Normalized();

            Velocity = direction * Speed;
        
        }
    }
    //move
    public override void _PhysicsProcess(double delta) {
        

        MoveAndSlide();
    }
      
    //Stop if the player is out
    public void OnPlayerOut(Node2D node){
      Velocity = Vector2.Zero;
        
    }
    //Player damage
    public void BodyEntered(Node2D node)
    {
     currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Velocity = Vector2.Zero;
            GD.Print("Player is dead");
        }
        
    }

}

 
        