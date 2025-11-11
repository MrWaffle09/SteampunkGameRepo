using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export] public int Speed { get; set; } = 70;

	private AnimatedSprite2D _anim;

	public override void _Ready()
	{
		_anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Handles Movement
	public void GetInput()
	{
		Vector2 inputDirection = Input.GetVector("MenuLeft", "MenuRight", "MenuUp", "MenuDown");
		Velocity = inputDirection * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();

		// ✅ FIXED: Flip sprite the correct direction
		if (Velocity.X != 0)
		{
			// If moving right -> flip OR if moving left -> no flip, depending on your sprite
			_anim.FlipH = Velocity.X > 0;
		}

		// Play/stop animations based on movement
		if (Velocity.LengthSquared() > 0.01f)
		{
			if (_anim.Animation != "walk")
				_anim.Play("walk");
		}
		else
		{
			if (_anim.SpriteFrames.HasAnimation("default"))
				_anim.Play("default");
			else
			{
				_anim.Stop();
				_anim.Frame = 0;
			}
		}

		MoveAndSlide();
	}
}
