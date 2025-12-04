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



    public enum PowerUps
    {

    Speed1 = 50,
    Speed2 = 100,
    Speed3 = 150,
    }

}
