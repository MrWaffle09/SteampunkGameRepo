using Godot;
using System;
using System.Collections.Generic;


public partial class GameManager : Node
{
    public static int CapyID = 0;
    public static int MechID = 0;  
    public static int MicroID = 0;
    public static int BullID = 0;


    public static List<string> activeCharacters = new List<string>();
    

    
    public enum StatusConditions
    {
        Stopped = 0,
        Stunned = 50,
        MNormal = 100,
        BNormal = 200,
        McNormal = 75,
        Dash = 300,
        Boost = 400,
        
    }
    
    
    
}
