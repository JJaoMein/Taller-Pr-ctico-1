using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critter
{
    public class Critter
    {
        private List<Skill> mySkills;
        public Skill skill;

        public enum EAfinity
        {
            Dark,
            Light,
            Fire,
            Water,
            Wind,
            Earth
        }

        private const int MAX_MOVESET = 3;
        private const int MIN_MOVESET = 1;

        public float DamageValue { get; protected set; }

        public string Name { get; private set; }

        public float BaseAttack { get; protected set; }

        public float BaseDefence { get; protected set; }

        public float BaseSpeed { get; protected set; }

        public float HP { get; set; }

        public EAfinity Afinity { get; protected set; }

        public List<Skill> MySkills { get; protected set; }

        public Critter(string name, float baseAttack, float baseDefence, float baseSpeed, EAfinity afinity, List<Skill> mySkills, float hp)
        {
            Name = name;
            BaseAttack = baseAttack;
            BaseDefence = baseDefence;
            BaseSpeed = baseSpeed;
            Afinity = afinity;
            MySkills = mySkills;
            HP = hp;
        }

        public void AttackSkill(Skill atkSkill)
        {
            if (skill.Power >= 1 && skill.Power <= 10 )
            {
                atkSkill = new Skill();
            }

        }

        public void SupportSkill(float buffAttack, float buffDefence, float buffSpeed, Skill supSkill)
        {
            if (skill.Power == 0)
            {
                supSkill = new Skill();

                int buffSpdCount = 0;
                int buffAtkCount = 0;
                int buffDefCount = 0;


                if (supSkill.SuppType == Skill.ESuppType.AtkUp && buffAtkCount < 3)
                {
                    buffAttack = BaseAttack * 1.20f;
                    buffAtkCount++;
                }
                else if (supSkill.SuppType == Skill.ESuppType.DefUp && buffDefCount < 3)
                {
                    buffDefence = BaseDefence * 1.20f;
                    buffDefCount++;
                }
                else if (supSkill.SuppType == Skill.ESuppType.SpdUp && buffSpdCount < 3)
                {
                    buffSpeed = BaseSpeed * 0.70f;
                    buffSpdCount++;
                }
            }
        }

        public void DamageReceived(float affinityMultiplier, Critter critter)
        {
            if (critter.Afinity == EAfinity.Dark && skill.AbilityAfinity == Skill.ESkillAfinity.Dark)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Dark && skill.AbilityAfinity == Skill.ESkillAfinity.Light)
            {
                affinityMultiplier = 2f;
            }
            else if (critter.Afinity == EAfinity.Light && skill.AbilityAfinity == Skill.ESkillAfinity.Dark)
            {
                affinityMultiplier = 2f;
            }
            else if (critter.Afinity == EAfinity.Light && skill.AbilityAfinity == Skill.ESkillAfinity.Light)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Fire && skill.AbilityAfinity == Skill.ESkillAfinity.Fire)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Fire && skill.AbilityAfinity == Skill.ESkillAfinity.Water)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Water && skill.AbilityAfinity == Skill.ESkillAfinity.Fire)
            {
                affinityMultiplier = 2f;
            }
            else if (critter.Afinity == EAfinity.Water && skill.AbilityAfinity == Skill.ESkillAfinity.Water)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Water && skill.AbilityAfinity == Skill.ESkillAfinity.Wind)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Wind && skill.AbilityAfinity == Skill.ESkillAfinity.Water)
            {
                affinityMultiplier = 2f;
            }
            else if (critter.Afinity == EAfinity.Wind && skill.AbilityAfinity == Skill.ESkillAfinity.Wind)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Wind && skill.AbilityAfinity == Skill.ESkillAfinity.Earth)
            {
                affinityMultiplier = 2f;
            }
            else if (critter.Afinity == EAfinity.Earth && skill.AbilityAfinity == Skill.ESkillAfinity.Fire)
            {
                affinityMultiplier = 0f;
            }
            else if (critter.Afinity == EAfinity.Earth && skill.AbilityAfinity == Skill.ESkillAfinity.Wind)
            {
                affinityMultiplier = 0.5f;
            }
            else if (critter.Afinity == EAfinity.Earth && skill.AbilityAfinity == Skill.ESkillAfinity.Earth)
            {
                affinityMultiplier = 0.5f;
            }
            else
            {
                affinityMultiplier = 1;
            }

            DamageValue = (BaseAttack + skill.Power) * affinityMultiplier;
            HP -= DamageValue;
        }




        



    }
}
