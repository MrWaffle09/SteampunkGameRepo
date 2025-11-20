using Godot;
using System;

public partial class CharacterSelector : Node2D
{
    private bool CapyCanSelect = true;
    private bool MicroCanSelect = true;
    private bool MechCanSelect = true;
    private bool BullCanSelect = true;

    [Export] private RichTextLabel _label;
    public override void _Input(InputEvent @event)
    {
        if(@event.IsActionPressed("Interact"))
        {
            if (CapyCanSelect)
            {
                GameManager.CapyID = @event.Device;
                CapyCanSelect = false;
                
            }
        }
    }
}
