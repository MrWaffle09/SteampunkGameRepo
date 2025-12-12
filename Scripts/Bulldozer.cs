using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class Bulldozer : Player
{
    
    public int CurrentHealth = 100;

    public AnimatedSprite2D animatedSprite2D;


    
    public override int speed { get; set; } = 150;

    public override void Die()
    {
        QueueFree();
    }
    public int damage = 20;
    
    public override void _Ready()
    {
        animatedSprite2D = GetNode<AnimatedSprite2D>("hp");
        
    }

    

	
    public override void _PhysicsProcess(double delta)
    {
        //handles movement
        float leftX = Input.GetJoyAxis(ID, JoyAxis.LeftX);
        if (Mathf.Abs(leftX) < 0.2)
        {
            leftX = 0;
        }
        float leftY = Input.GetJoyAxis(ID, JoyAxis.LeftY);
        if (Mathf.Abs(leftY) < 0.2)
        {
            leftY = 0;
        }
        Vector2 direction = new Vector2(leftX, leftY);
        Vector2 velocity = Velocity;
        if (direction != Vector2.Zero)
        {
            velocity = direction * speed;
        }
        else
        {
            velocity.X = Mathf.MoveToward(velocity.X, 0, speed);
            velocity.Y = Mathf.MoveToward(velocity.Y, 0, speed);
        }

        Velocity = velocity;
        MoveAndSlide();
    }
    public void OnEnemyEntered(Node2D node)
    
    {
        
       if (node is BasicEnemy)
        {
            CurrentHealth -= damage;
             
        if (CurrentHealth <= 80)
        {
            animatedSprite2D.Play("hp_80");
            GD.Print("no health");
        }
        if (currentHealth <= 60)
        {
            animatedSprite2D.Play("hp_60");
        }
        if (currentHealth <= 40)
        {
            animatedSprite2D.Play("hp_40");
        }
        if (currentHealth <= 20)
        {
            animatedSprite2D.Play("hp_20");
        }
        if (currentHealth <= 0)
        {
            Die();
        }
        }
    }

}
