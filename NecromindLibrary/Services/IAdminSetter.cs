namespace NecromindLibrary.Services
{
    public interface IAdminSetter
    {
        void AdminSetName(string name);

        void AdminSetGold(string gold);

        void AdminSetGold(int gold);

        void AdminSetLvl(string lvl);

        void AdminSetLvl(int lvl);

        void AdminSetDmgMin(string dmg);

        void AdminSetDmgMin(int dmg);

        void AdminSetDmgMax(string dmg);

        void AdminSetDmgMax(int dmg);

        void AdminSetDef(string def);

        void AdminSetDef(int def);

        void AdminSetHealth(string health);

        void AdminSetHealth(int health);
    }
}