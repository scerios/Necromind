using NecromindLibrary.Services;
using System;

namespace NecromindLibrary.Models
{
    public class HeroAdminModel : HeroModel, IAdminSetter
    {
        public HeroAdminModel(string name) : base(name)
        {
        }

        public void AdminSetName(string name)
        {
            Name = name;
        }

        public void AdminSetGold(string gold)
        {
            _gold = Int32.Parse(gold);
        }

        public void AdminSetLvl(string lvl)
        {
            _lvl = Int32.Parse(lvl);
        }

        public void AdminSetDmgMin(string dmg)
        {
            _dmgMin = Int32.Parse(dmg);
        }

        public void AdminSetDmgMax(string dmg)
        {
            _dmgMax = Int32.Parse(dmg);
        }

        public void AdminSetDef(string def)
        {
            _def = Int32.Parse(def);
        }

        public void AdminSetHealth(string health)
        {
            var healthAsInt = Int32.Parse(health);
            _healthMax = healthAsInt;
            _health = healthAsInt;
        }
    }
}