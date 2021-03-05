namespace NecromindLibrary.Services
{
    public interface IAdminSetter
    {
        void AdminSetName(string name);

        void AdminSetGold(int gold);

        void AdminSetLvl(int lvl);

        void AdminSetDmg(int dmg);

        void AdminSetDef(int def);

        void AdminSetHealth(int health);
    }
}