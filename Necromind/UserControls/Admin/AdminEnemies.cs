using NecromindUI.Presenters;
using NecromindUI.Views;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminEnemies : UserControl, IAdminEnemies
    {
        private readonly AdminEnemiesPresenter _presenter;

        public string EnemyName
        {
            get => tbName.Text;
            set
            {
                tbName.Text = value;
            }
        }

        public string Lvl
        {
            get => tbLvl.Text;

            set
            {
                tbLvl.Text = value;
            }
        }

        public string Gold
        {
            get => tbGold.Text;

            set
            {
                tbGold.Text = value;
            }
        }

        public string DmgMin
        {
            get => tbDmgMin.Text;

            set
            {
                tbDmgMin.Text = value;
            }
        }

        public string DmgMax
        {
            get => tbDmgMax.Text;

            set
            {
                tbDmgMax.Text = value;
            }
        }

        public string Def
        {
            get => tbDef.Text;

            set
            {
                tbDef.Text = value;
            }
        }

        public string Health
        {
            get => tbHealth.Text;

            set
            {
                tbHealth.Text = value;
            }
        }

        public Timer TimHide
        {
            get => timHide;
        }

        public Label LabEnemyAdded
        {
            get => labEnemyAdded;
        }

        public AdminEnemies()
        {
            InitializeComponent();
            _presenter = new AdminEnemiesPresenter(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddEnemy();
        }

        private void TimHide_Tick(object sender, EventArgs e)
        {
            labEnemyAdded.Visible = false;
            timHide.Stop();
        }
    }
}