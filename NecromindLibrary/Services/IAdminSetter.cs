namespace NecromindLibrary.Services
{
    public interface IAdminSetter
    {
        void AdminSetName(string name);

        void AdminSetGold(int gold);

        void AdminSetLvl(int lvl);

        void AdminSetDmgMin(int dmg);

        void AdminSetDmgMax(int dmg);

        void AdminSetDef(int def);

        void AdminSetHealth(int health);
    }
}