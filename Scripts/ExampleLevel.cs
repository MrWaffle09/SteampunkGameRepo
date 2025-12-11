using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class ExampleLevel : Node2D
{
    public PackedScene Microwave = GD.Load<PackedScene>("res://Scenes/microwavejo.tscn");
    public PackedScene Bulldozer = GD.Load<PackedScene>("res://Scenes/bulldozer.tscn");
    public PackedScene Mechanic = GD.Load<PackedScene>("res://Scenes/mechanic.tscn");
    public PackedScene Capybara = GD.Load<PackedScene>("res://Scenes/capybara.tscn");

    public override void _Ready()
    {
        if (GameManager.activeCharacters.Contains("Micro"))
        {
            var currentMicrowave = Microwave.Instantiate<Player>();
            AddChild(currentMicrowave);
            currentMicrowave.ID = GameManager.MicroID;
        }

        if (GameManager.activeCharacters.Contains("Mech"))
        {
            var currentMechanic = Mechanic.Instantiate<Player>();
            AddChild(currentMechanic);
            currentMechanic.ID = GameManager.MechID;
        }

        if (GameManager.activeCharacters.Contains("Capy"))
        {
            var currentCapybara = Capybara.Instantiate<Player>();
            AddChild(currentCapybara);
            currentCapybara.ID = GameManager.CapyID;
        }

        if (GameManager.activeCharacters.Contains("Bull"))
        {
            var currentBulldozer = Bulldozer.Instantiate<Player>();
            AddChild(currentBulldozer);
            currentBulldozer.ID = GameManager.BullID;
            GD.Print(GameManager.BullID);
            GD.Print(currentBulldozer.ID);
        }

    }
}



