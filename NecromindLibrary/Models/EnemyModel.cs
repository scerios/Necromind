using NecromindLibrary.Services;
using System;

namespace NecromindLibrary.Models
{
    public class EnemyModel : BaseModel, IFighter, IAdminSetter
    {
        public int DmgMin { get; private set; }
        public int DmgMax { get; private set; }

        public int Def { get; private set; }

        public int Health { get; private set; }

        public int HealthMax { get; private set; }

        /// <summary>
        /// This constructor is for testing purposes.
        /// </summary>
        public EnemyModel()
        {
            Gold = 100;
            Lvl = 1;
            DmgMin = 5;
            DmgMax = 5;
            Def = 5;
            Health = 5;
            HealthMax = 5;
        }

        public EnemyModel(EnemyModel scheme)
        {
            Id = scheme.Id;
            Name = scheme.Name;
            Gold = scheme.Gold;
            Lvl = scheme.Lvl;
            DmgMin = scheme.DmgMin;
            DmgMax = scheme.DmgMax;
            Def = scheme.Def;
            Health = scheme.Health;
            HealthMax = scheme.HealthMax;
        }

        public void Attack(IFighter enemy)
        {
            enemy.TakeDmg(this);
        }

        public void TakeDmg(IFighter enemy)
        {
            // TODO - Implement take dmg logic.
        }

        public void Die(IFighter enemy)
        {
            var levelablePlayer = enemy as ILevelable;
            levelablePlayer.GainExperience(Lvl);

            var traderPlayer = enemy as ITrader;
            traderPlayer.RecieveGold(Gold);
        }

        public void AdminSetName(string name)
        {
            Name = name;
        }

        public void AdminSetGold(int gold)
        {
            Gold = gold;
        }

        public void AdminSetLvl(int lvl)
        {
            Lvl = lvl;
        }

        public void AdminSetDmgMin(int dmg)
        {
            DmgMin = dmg;
        }

        public void AdminSetDmgMax(int dmg)
        {
            DmgMax = dmg;
        }

        public void AdminSetDef(int def)
        {
            Def = def;
        }

        public void AdminSetHealth(int health)
        {
            HealthMax = health;
            Health = health;
        }
    }
}