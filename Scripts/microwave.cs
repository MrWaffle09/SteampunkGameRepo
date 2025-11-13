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

	// Handles Movement (supports both arrows and WASD)
	public void GetInput()
	{
		float x = 0;
		float y = 0;

		// Horizontal input
		if (Input.IsActionPressed("ui_left") || Input.IsKeyPressed(Key.A))
			x -= 1;
		if (Input.IsActionPressed("ui_right") || Input.IsKeyPressed(Key.D))
			x += 1;

		// Vertical input
		if (Input.IsActionPressed("ui_up") || Input.IsKeyPressed(Key.W))
			y -= 1;
		if (Input.IsActionPressed("ui_down") || Input.IsKeyPressed(Key.S))
			y += 1;

		Vector2 inputDirection = new Vector2(x, y).Normalized();
		Velocity = inputDirection * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();

		// Flip facing direction
		if (!Mathf.IsZeroApprox(Velocity.X))
			_anim.FlipH = Velocity.X > 0;

		bool isMoving = !Velocity.IsZeroApprox();

		// Choose animation
		if (isMoving)
		{
			if (_anim.Animation != "walk")
				_anim.Play("walk");
			_anim.SpeedScale = 1.0f;
		}
		else
		{
			if (_anim.SpriteFrames.HasAnimation("idle"))
			{
				if (_anim.Animation != "idle")
					_anim.Play("idle");
				_anim.SpeedScale = 1.0f;
			}
			else
			{
				if (_anim.Animation != "walk")
					_anim.Play("walk");
				_anim.Frame = 0;
				_anim.SpeedScale = 0.0f;
			}
		}

		MoveAndSlide();
	}
}
