﻿using NecromindUI.Presenters.Admin;
using NecromindUI.Views.Admin;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminLocations : UserControl, IAdminLocations
    {
        #region Properties

        private readonly AdminLocationsPresenter _presenter;

        public string TbCreateName
        {
            get => tbCreateName.Text;

            set
            {
                tbCreateName.Text = value;
            }
        }

        public string TbEditName
        {
            get => tbEditName.Text;

            set
            {
                tbEditName.Text = value;
            }
        }

        public string TbCreateDescription
        {
            get => tbCreateDescription.Text;

            set
            {
                tbCreateDescription.Text = value;
            }
        }

        public string TbEditDescription
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

        public bool CbCreateIsAccessible
        {
            get => cbCreateIsAccessible.Checked;

            set
            {
                cbCreateIsAccessible.Checked = value;
            }
        }

        public bool CbEditIsAccessible
        {
            get => cbEditIsAccessible.Checked;

            set
            {
                cbEditIsAccessible.Checked = value;
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

        public bool LabNameCError
        {
            get => labNameCError.Visible;

            set
            {
                labNameCError.Visible = value;
            }
        }

        public bool LabNameMError
        {
            get => labNameMError.Visible;

            set
            {
                labNameMError.Visible = value;
            }
        }

        public ListBox LbLocations
        {
            get => lbLocations;
        }

        public ListBox LbCreateEnemies
        {
            get => lbCreateEnemies;
        }

        public ListBox LbCreateAddedEnemies
        {
            get => lbCreateAddedEnemies;
        }

        public ListBox LbEditEnemies
        {
            get => lbEditEnemies;
        }

        public ListBox LbEditAddedEnemies
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

        public Label LabLocationAdd
        {
            get => labEnemyAdd;
        }

        public Label LabLocationEdit
        {
            get => labEnemyEdit;
        }

        #endregion Properties

        public AdminLocations()
        {
            InitializeComponent();
            _presenter = new AdminLocationsPresenter(this);
        }

        #region Methods

        public void LoadData()
        {
            _presenter.LoadData();
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
            _presenter.CreateAdd();
        }

        private void BtnCreateRemove_Click(object sender, EventArgs e)
        {
            _presenter.CreateRemove();
        }

        private void BtnEditAdd_Click(object sender, EventArgs e)
        {
            _presenter.EditAdd();
        }

        private void BtnEditRemove_Click(object sender, EventArgs e)
        {
            _presenter.EditRemove();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (_presenter.AreCreateFieldsValid())
                _presenter.CreateLocation();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_presenter.IsLocationSelected() && _presenter.AreEditFieldsValid())
                _presenter.EditLocation();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (_presenter.IsLocationSelected() && _presenter.AreEditFieldsValid())
                _presenter.DeleteLocation();
        }

        private void TimHideAdd_Tick(object sender, EventArgs e)
        {
            LabLocationAdd.Visible = false;
            TimHideAdd.Stop();
        }

        private void TimHideEdit_Tick(object sender, EventArgs e)
        {
            LabLocationEdit.Visible = false;
            TimHideEdit.Stop();
        }

        private void LbCreateEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCreateEnemies.SelectedIndex >= 0)
            {
                btnCreateAdd.Enabled = true;
            }
            else
            {
                btnCreateAdd.Enabled = false;
            }
        }

        private void LbCreateAddedEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCreateAddedEnemies.SelectedIndex >= 0)
            {
                btnCreateRemove.Enabled = true;
            }
            else
            {
                btnCreateRemove.Enabled = false;
            }
        }

        private void LbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.SetSelectedLocationStats();
        }

        private void LbEditEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEditEnemies.SelectedIndex >= 0)
            {
                btnEditAdd.Enabled = true;
            }
            else
            {
                btnEditAdd.Enabled = false;
            }
        }

        private void LbEditAddedEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEditAddedEnemies.SelectedIndex >= 0)
            {
                btnEditRemove.Enabled = true;
            }
            else
            {
                btnEditRemove.Enabled = false;
            }
        }

        #endregion Methods
    }
}