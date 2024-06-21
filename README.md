# Simple-Skills
Scripts that will give you ready-to-go skill system for Unity.

The guide how to use it:

1. Import all scripts into Unity.
2. Create empty game object and attach SkillManager script to it.
3. Create unique button (UI) for each skill and attach to each a SkillController script. Then in OnClick add BuySkill method from SkillController. IMPORTANT, add method from THIS button for each button, that way buttons will give effects that they are meant to. If everything is done right, then those button will be responsible for buying skill.
4. Set variables for each skill (you can do it directly in Inspector). Here is a description for a few variables   
   ID - Unique ID (number) that should be different from ALL other skills' ID.
   Type - Types are used to give boosts/effects of skills. So there can be one type for two (or more) skills. For example, you can mark (for yourself) type 1 as +10 health effect, then set type 1 for one of your skills. If you want to have another skill that gives you +10 health effect, you don't need to give it another type, just give it same type as for skill with the same function. IMPORTANT, you still need to use two different IDs, even if skills are the same type.
   Cost - this is how many skill points (variable in SkillManager script) will skill unlock take to be unlocked.
   Dependencies - if you want to, you can make that some skills will require player having some skills already unlocked. Here you write IDs of skills that need to be unlocked in order to have ability to unlock this skill. If you don't want skill to have any dependecies, then just don't touch it/set it to zero.
5. Add effects for each type in SkillController script in switch structure.

And that's all of it. If you have any questions feel free to ask. You can also try to modify my system and add your unique features.
