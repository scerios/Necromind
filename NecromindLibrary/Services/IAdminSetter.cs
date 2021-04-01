namespace NecromindLibrary.Services
{
    public interface IAdminSetter
    {
        void AdminSetName(string name);

        void AdminSetGold(int gold);

        void AdminSetGold(string gold);

        void AdminSetLvl(int lvl);

        void AdminSetLvl(string lvl);

        void AdminSetDmgMin(int dmg);

        void AdminSetDmgMin(string dmg);

        void AdminSetDmgMax(int dmg);

        void AdminSetDmgMax(string dmg);

        void AdminSetDef(int def);

        void AdminSetDef(string def);

        void AdminSetHealth(int health);

        void AdminSetHealth(string health);
    }
}