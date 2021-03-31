using NecromindUI.Presenters.Admin;
using NecromindUI.Views.Admin;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminEnemies : UserControl, IAdminEnemies
    {
        private readonly AdminEnemiesPresenter _presenter;

        public string AddEnemyName
        {
            get => tbCreateName.Text;
            set
            {
                tbCreateName.Text = value;
            }
        }

        public string EditEnemyName
        {
            get => tbEditName.Text;
            set
            {
                tbEditName.Text = value;
            }
        }

        public string AddLvl
        {
            get => tbCreateLvl.Text;

            set
            {
                tbCreateLvl.Text = value;
            }
        }

        public string EditLvl
        {
            get => tbEditLvl.Text;

            set
            {
                tbEditLvl.Text = value;
            }
        }

        public string AddGold
        {
            get => tbCreateGold.Text;

            set
            {
                tbCreateGold.Text = value;
            }
        }

        public string EditGold
        {
            get => tbEditGold.Text;

            set
            {
                tbEditGold.Text = value;
            }
        }

        public string AddDmgMin
        {
            get => tbCreateDmgMin.Text;

            set
            {
                tbCreateDmgMin.Text = value;
            }
        }

        public string EditDmgMin
        {
            get => tbEditDmgMin.Text;

            set
            {
                tbEditDmgMin.Text = value;
            }
        }

        public string AddDmgMax
        {
            get => tbCreateDmgMax.Text;

            set
            {
                tbCreateDmgMax.Text = value;
            }
        }

        public string EditDmgMax
        {
            get => tbEditDmgMax.Text;

            set
            {
                tbEditDmgMax.Text = value;
            }
        }

        public string AddDef
        {
            get => tbCreateDef.Text;

            set
            {
                tbCreateDef.Text = value;
            }
        }

        public string EditDef
        {
            get => tbEditDef.Text;

            set
            {
                tbEditDef.Text = value;
            }
        }

        public string AddHealth
        {
            get => tbCreateHealth.Text;

            set
            {
                tbCreateHealth.Text = value;
            }
        }

        public string EditHealth
        {
            get => tbEditHealth.Text;

            set
            {
                tbEditHealth.Text = value;
            }
        }

        public ListBox Enemies
        {
            get => lbEnemies;
        }

        public Timer TimHideAdd
        {
            get => timHideAdd;
        }

        public Timer TimHideEdit
        {
            get => timHideEdit;
        }

        public Label LabEnemyAdd
        {
            get => labEnemyAdd;
        }

        public Label LabEnemyEdit
        {
            get => labEnemyEdit;
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _presenter.EditEnemy();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            _presenter.DeleteEnemy();
        }

        private void TimHideAdd_Tick(object sender, EventArgs e)
        {
            LabEnemyAdd.Visible = false;
            TimHideAdd.Stop();
        }

        private void TimHideEdit_Tick(object sender, EventArgs e)
        {
            LabEnemyEdit.Visible = false;
            TimHideEdit.Stop();
        }

        private void LbEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.GetSelectedEnemyStats();
        }
    }
}