using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SkillController : MonoBehaviour
{
    public Skill Skill;

    [SerializeField]
    private SkillManager manager;

    public void BuySkill()
    {
        if (Skill.Cost <= manager.SkillPoints && !Skill.Unlocked && Skill.Dependencies.All(dependency => manager.UnlockedSkills.Contains(dependency)))
        {
            manager.SkillPoints -= Skill.Cost;
            Skill.Unlocked = true;
            manager.UnlockedSkills = manager.UnlockedSkills.Concat(new int[] { Skill.ID }).ToArray();
            switch (Skill.Type)
            {
                // write your effects here
            }
        }
    }
}
