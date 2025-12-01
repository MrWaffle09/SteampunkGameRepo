using Godot;
using System;

public partial class BasicEnemy: CharacterBody2D
{
    //The enemy variables
    public int Speed = 100; 
    private CharacterBody2D Player;
    public int currentHealth = 110;
    public int damage = 20;
    public AnimatedSprite2D animatedSprite2D;
    public void Dead()
	{
		QueueFree();
	}

    public override void _Ready()
    {
        animatedSprite2D = GetNode<AnimatedSprite2D>("health");
        
    }

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
        if (currentHealth <= 80)
        {
            animatedSprite2D.Play("5_hp");
        }
        if (currentHealth <= 60)
        {
            animatedSprite2D.Play("4_hp");
        }
        if (currentHealth <= 40)
        {
            animatedSprite2D.Play("3_hp");
        }
        if (currentHealth <= 20)
        {
            animatedSprite2D.Play("2_hp");
        }
        if (currentHealth <= 10)
        {
            animatedSprite2D.Play("1_hp");
        }
        if (currentHealth <= 0)
        {
            Velocity = Vector2.Zero;
            Dead();
        }


        
    }
    public void PlayerOut(Node2D node)
    {

    }

}

 
        