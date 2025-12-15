using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class Mechanic : Player
{

    public override int speed { get; set; } = 75;
    public int CurrentHealth = 100;
    private int steam = 0;
    private AnimatedSprite2D steamSprite;
    private CustomSignals _customSignals;


    public override void Die()
    {
        GameManager.activeCharacters.Remove("Mech");
        GameManager.alivePlayers -= 1;
        if (GameManager.alivePlayers < 1)
        {
            GetTree().ChangeSceneToFile("res://Scenes/lose_screen.tscn");
        }
        QueueFree();


    }
    public override void _Ready()
    {
        _customSignals = GetNode<CustomSignals>("/root/CustomSignals");
        _customSignals.SpeedUp += SpeedUp;
        steamSprite = GetNode<AnimatedSprite2D>("hp");
        SteamTick();
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
    
    public async void SteamTick()
    {
        while (steam <= 4)
        {
            await ToSignal(GetTree().CreateTimer(10f), "timeout");
            steam += 1;
            CurrentHealth -= 20;
            GD.Print(CurrentHealth);

            if (CurrentHealth <= 0)
            {
                Die();
            }
            else if (CurrentHealth <= 20)
            {
                steamSprite.Play("hp_20");
            }
            else if (CurrentHealth <= 40)
            {
                steamSprite.Play("hp_40");
            }
            else if (CurrentHealth <= 60)
            {
                steamSprite.Play("hp_60");
            }
            else if (CurrentHealth <= 80)
            {
                steamSprite.Play("hp_80");
            }
        }
    } 
    private void SpeedUp(int speedUpAmount)
    {
        speed += speedUpAmount;
    }
}
