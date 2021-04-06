namespace NecromindLibrary.Services
{
    public interface IAdminSetter
    {
        void AdminSetName(string name);

        void AdminSetGold(string gold);

        void AdminSetLvl(string lvl);

        void AdminSetDmgMin(string dmg);

        void AdminSetDmgMax(string dmg);

        void AdminSetDef(string def);

        void AdminSetHealth(string health);
    }
}