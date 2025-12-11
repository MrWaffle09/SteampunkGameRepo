using Godot;
using System;
using Godot.Collections;
using MultiplayerProject.Scripts;

public partial class Microwave : Player
{
	public int ID { get; set; } = 0;
	public int speed { get; set; } = 100;

	public override void Die()
	{
		QueueFree();
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
}
