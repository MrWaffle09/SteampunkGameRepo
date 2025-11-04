using Godot;

namespace MultiplayerProject.Scripts;

public abstract class Player
{
    

    [Export] public virtual int speed { get; set; } = 100;
    [Export] public virtual int health { get; set; } = 100;

}