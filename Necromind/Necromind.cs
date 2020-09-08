using NecromindLibrary.models;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
        public Necromind()
        {
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
        }

        private void Necromind_Load(object sender, EventArgs e)
        {
            try
            {
                List<HeroModel> heroes = DataAccess.GetAllSavedHeroes();
                foreach (HeroModel hero in heroes)
                {
                    Console.WriteLine("Max hitpoints: " + hero.HitPointsMax + ", Items in bag: " + hero.ItemIds);
                    List<QuestModel> quests = DataAccess.GetQuestForHeroById(hero.Id, hero.QuestsIds);
                    foreach (QuestModel quest in quests)
                    {
                        Console.WriteLine($"Active quests for { hero.Name }: " + quest.Name);
                    }
                }
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
