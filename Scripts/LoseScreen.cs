using Godot;
using System;

public partial class LoseScreen : Node2D
{
    public async override void _Input(InputEvent @event)
    {
        await ToSignal(GetTree().CreateTimer(5f), "timeout");
        GetTree().Quit();
    }
}
