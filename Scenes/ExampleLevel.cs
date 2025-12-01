using Godot;
using System;

public partial class ExampleLevel : Node2D
{
    public PackedScene Microwave = GD.Load<PackedScene>("res://Scenes/microwavejo.tscn");
    public PackedScene Bulldozer = GD.Load<PackedScene>("res://Scenes/bulldozer.tscn");
    public PackedScene Mechanic = GD.Load<PackedScene>("res://Scenes/mechanic.tscn");
    public PackedScene Capybara = GD.Load<PackedScene>("res://Scenes/capybara.tscn");
    
    public override void _Ready()
    {
        GD.Print(GameManager.activeCharacters);
        if (GameManager.activeCharacters.Contains("Micro"));
        {
            var currentMicrowave = Microwave;
            currentMicrowave.Instantiate<CharacterBody2D>();
        }
    }
}
