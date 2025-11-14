using System;
using Godot;

namespace MultiplayerProject.Scripts;

public abstract partial class Player : CharacterBody2D
{

    [Export] public virtual int ID { get; set; } = 0;
    [Export] public virtual int speed { get; set; } = 100;
    [Export] public virtual int maxHealth { get; set; } = 100;
    public virtual int currentHealth { get; set; }

    public override void _Ready()
    {
        currentHealth = maxHealth;
    }

    public abstract void Die();

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }

    }


    
 


    
}