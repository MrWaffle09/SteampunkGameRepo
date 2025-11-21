using Godot;
using System;

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

    public override void _Ready()
    {
        _capyText = GetNode<RichTextLabel>("ColorRect/CapyLabel");
        _microText = GetNode<RichTextLabel>("ColorRect/MicroLabel");
        _mechText = GetNode<RichTextLabel>("ColorRect/MechLabel");
        _bullText = GetNode<RichTextLabel>("ColorRect/BullLabel");
    }

    public override void _Input(InputEvent @event)
    {
        if(@event.IsActionPressed("Interact"))
        {
            if (CapyCanSelect)
            {
                GameManager.CapyID = @event.Device;
                CapyCanSelect = false;
                _capyText.Text = "Selceted";
                GD.Print(@event.Device);
                GD.Print(GameManager.CapyID);
            }
        }

        if (@event.IsActionPressed("BackOut"))
        {
            if (MechCanSelect)
            {
                GameManager.MechID = @event.Device;
                MechCanSelect = false;
                _mechText.Text = "Selected";
                GD.Print(@event.Device);
                GD.Print(GameManager.MechID);
            }
        }
    }
}
