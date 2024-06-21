using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill
{
    public int ID;
    public int Type;

    public string Name;
    public string Description;
    public int Cost;
    public int[] Dependencies;

    public bool Unlocked;
}
