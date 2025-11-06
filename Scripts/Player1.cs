using Godot;
using System;
using Godot.Collections;
using MultiplayerProject.Scripts;

public partial class Player1 : Player
{
    public override void Die()
    {
        QueueFree();
    }
    
}
