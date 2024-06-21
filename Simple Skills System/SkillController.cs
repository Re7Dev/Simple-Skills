using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SkillController : MonoBehaviour
{
    public Skill Skill;
    public int SkillPoints;

    [SerializeField]
    private SkillManager manager;

    public void BuySkill()
    {
        if (Skill.Cost <= SkillPoints && !Skill.Unlocked && Skill.Dependencies.All(dependency => manager.UnlockedSkills.Contains(dependency)))
        {
            SkillPoints -= Skill.Cost;
            Skill.Unlocked = true;
            manager.UnlockedSkills = manager.UnlockedSkills.Concat(new int[] { Skill.ID }).ToArray();
            switch (Skill.Type)
            {
                // write your effects here
            }
        }
    }
}
