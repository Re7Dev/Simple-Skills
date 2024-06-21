using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public int SkillPoints;
    public int[] UnlockedSkills = new int[1];

    private void Start()
    {
        UnlockedSkills = new int[1];
        UnlockedSkills[0] = 0;
    }

}
