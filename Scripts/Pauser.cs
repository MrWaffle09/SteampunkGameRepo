using Godot;
using System;

public partial class Pauser : Node
{
    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("Pause"))
        {
            GetTree().Paused = !GetTree().Paused;

        }
    }
}

