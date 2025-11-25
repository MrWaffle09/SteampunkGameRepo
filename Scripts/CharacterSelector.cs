using Godot;
using System;
using System.Collections.Generic;


public partial class CharacterSelector : Node2D
{
    private bool CapyCanSelect = true;
    private bool MicroCanSelect = true;
    private bool MechCanSelect = true;
    private bool BullCanSelect = true;
    
    private RichTextLabel _capyText;
    private RichTextLabel _microText;
    private RichTextLabel _mechText;
    private RichTextLabel _bullText;

    private List<int> UsedIDs = new List<int>();

    public override void _Ready()
    {
        _capyText = GetNode<RichTextLabel>("ColorRect/CapyLabel");
        _microText = GetNode<RichTextLabel>("ColorRect/MicroLabel");
        _mechText = GetNode<RichTextLabel>("ColorRect/MechLabel");
        _bullText = GetNode<RichTextLabel>("ColorRect/BullLabel");
    }

    
    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("Interact"))
        {
            if (CapyCanSelect)
            {
                if (!UsedIDs.Contains(@event.Device))
                {
                    GameManager.CapyID = @event.Device;
                    CapyCanSelect = false;
                    _capyText.Text = "Seleceted";
                    UsedIDs.Add(@event.Device);
                    GameManager.activeCharacters.Add("Capy");
                }
            }
        }

        if (@event.IsActionPressed("BackOut"))
        {
            if (MechCanSelect)
            {
                if (!UsedIDs.Contains(@event.Device))
                {
                    GameManager.MechID = @event.Device;
                    MechCanSelect = false;
                    _mechText.Text = "Selected";
                    UsedIDs.Add(@event.Device);
                    GameManager.activeCharacters.Add("Mech");   
                }
            }
        }

        if (@event.IsActionPressed("PowerUp"))
        {
            if (MicroCanSelect)
            {
                if (!UsedIDs.Contains(@event.Device))
                {
                    GameManager.MicroID = @event.Device;
                    MicroCanSelect = false;
                    _microText.Text = "Selected";
                    UsedIDs.Add(@event.Device);
                    GameManager.activeCharacters.Add("Micro");
                }
            }
        }

        if (@event.IsActionPressed("Y"))
        {
            if (BullCanSelect)
            {
                if (!UsedIDs.Contains(@event.Device))
                {
                    GameManager.BullID = @event.Device;
                    BullCanSelect = false;
                    _bullText.Text = "Selected";
                    UsedIDs.Add(@event.Device);
                    GameManager.activeCharacters.Add("Bull");
                }
            }
        }

        if (@event.IsActionPressed("Pause"))
        {
            GetTree().ChangeSceneToFile("res://Scenes/ExampleLevel.tscn");
        }
    }
}
