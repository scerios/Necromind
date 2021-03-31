using NecromindUI.Presenters.Admin;
using NecromindUI.Views.Admin;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminLocations : UserControl, IAdminLocations
    {
        private readonly AdminLocationsPresenter _presenter;

        public string CreateName
        {
            get => tbCreateName.Text;

            set
            {
                tbCreateName.Text = value;
            }
        }

        public string EditName
        {
            get => tbEditName.Text;

            set
            {
                tbEditName.Text = value;
            }
        }

        public string CreateDescription
        {
            get => tbCreateDescription.Text;

            set
            {
                tbCreateDescription.Text = value;
            }
        }

        public string EditDescription
        {
            get => tbEditDescription.Text;

            set
            {
                tbEditDescription.Text = value;
            }
        }

        public bool CbCreateIsHostile
        {
            get => cbCreateIsHostile.Checked;

            set
            {
                cbCreateIsHostile.Checked = value;
            }
        }

        public bool CbEditIsHostile
        {
            get => cbEditIsHostile.Checked;

            set
            {
                cbEditIsHostile.Checked = value;
            }
        }

        public bool PanCreateEnemies
        {
            get => panCreateEnemies.Visible;
            set
            {
                panCreateEnemies.Visible = value;
            }
        }

        public bool PanEditEnemies
        {
            get => panEditEnemies.Visible;
            set
            {
                panEditEnemies.Visible = value;
            }
        }

        public ListBox Locations
        {
            get => lbLocations;
        }

        public ListBox CreateEnemies
        {
            get => lbCreateEnemies;
        }

        public ListBox CreateAddedEnemies
        {
            get => lbCreateAddedEnemies;
        }

        public ListBox EditEnemies
        {
            get => lbEditEnemies;
        }

        public ListBox EditAddedEnemies
        {
            get => lbEditAddedEnemies;
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

        public AdminLocations()
        {
            InitializeComponent();
            _presenter = new AdminLocationsPresenter(this);
        }

        private void CbCreateIsHostile_CheckedChanged(object sender, EventArgs e)
        {
            PanCreateEnemies = CbCreateIsHostile;
        }

        private void CbEditIsHostile_CheckedChanged(object sender, EventArgs e)
        {
            PanEditEnemies = CbEditIsHostile;
        }

        private void BtnCreateAdd_Click(object sender, EventArgs e)
        {
        }

        private void BtnCreateRemove_Click(object sender, EventArgs e)
        {
        }

        private void BtnEditAdd_Click(object sender, EventArgs e)
        {
        }

        private void BtnEditRemove_Click(object sender, EventArgs e)
        {
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
        }
    }
}