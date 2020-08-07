using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critter
{
    public class Skill
    {
        public string Name {get; protected set;}

        public enum ESkillAfinity
        {
            Dark, 
            Light,
            Fire,
            Water,
            Wind,
            Earth
        }

        public enum ESkillType
        {
            SupportSkill,
            AttackSkill
        }

        public enum ESuppType
        {
            AtkUp,
            DefUp,
            SpdUp
        }

        public int Power {get; protected set;}

        public ESkillAfinity AbilityAfinity { get; protected set; }

        public ESkillType SkillType {get; protected set; }

        public ESuppType SuppType { get; protected set; }

    }
}
