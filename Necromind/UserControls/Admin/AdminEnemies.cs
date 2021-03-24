using NecromindUI.Presenters;
using NecromindUI.Views;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminEnemies : UserControl, IAdminEnemies
    {
        private readonly AdminEnemiesPresenter _presenter;

        public string AddEnemyName
        {
            get => tbAddName.Text;
            set
            {
                tbAddName.Text = value;
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
            get => tbAddLvl.Text;

            set
            {
                tbAddLvl.Text = value;
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
            get => tbAddGold.Text;

            set
            {
                tbAddGold.Text = value;
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
            get => tbAddDmgMin.Text;

            set
            {
                tbAddDmgMin.Text = value;
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
            get => tbAddDmgMax.Text;

            set
            {
                tbAddDmgMax.Text = value;
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
            get => tbAddDef.Text;

            set
            {
                tbAddDef.Text = value;
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
            get => tbAddHealth.Text;

            set
            {
                tbAddHealth.Text = value;
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