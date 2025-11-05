using Godot;
using System;
using MultiplayerProject.Scripts;

public partial class Player1 : Player
{
    public override void Die()
    { 
        QueueFree();
    }
    

}
