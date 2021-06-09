using NecromindUI.Presenters.Admin;
using NecromindUI.Views.Admin;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminEnemies : UserControl, IAdminEnemies
    {
        #region Properties

        private readonly AdminEnemiesPresenter _presenter;

        #region Textboxes

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

        public string TbCreateLvl
        {
            get => tbCreateLvl.Text;

            set
            {
                tbCreateLvl.Text = value;
            }
        }

        public string TbEditLvl
        {
            get => tbEditLvl.Text;

            set
            {
                tbEditLvl.Text = value;
            }
        }

        public string TbCreateGold
        {
            get => tbCreateGold.Text;

            set
            {
                tbCreateGold.Text = value;
            }
        }

        public string TbEditGold
        {
            get => tbEditGold.Text;

            set
            {
                tbEditGold.Text = value;
            }
        }

        public string TbCreateDmgMin
        {
            get => tbCreateDmgMin.Text;

            set
            {
                tbCreateDmgMin.Text = value;
            }
        }

        public string TbEditDmgMin
        {
            get => tbEditDmgMin.Text;

            set
            {
                tbEditDmgMin.Text = value;
            }
        }

        public string TbCreateDmgMax
        {
            get => tbCreateDmgMax.Text;

            set
            {
                tbCreateDmgMax.Text = value;
            }
        }

        public string TbEditDmgMax
        {
            get => tbEditDmgMax.Text;

            set
            {
                tbEditDmgMax.Text = value;
            }
        }

        public string TbCreateDef
        {
            get => tbCreateDef.Text;

            set
            {
                tbCreateDef.Text = value;
            }
        }

        public string TbEditDef
        {
            get => tbEditDef.Text;

            set
            {
                tbEditDef.Text = value;
            }
        }

        public string TbCreateHealth
        {
            get => tbCreateHealth.Text;

            set
            {
                tbCreateHealth.Text = value;
            }
        }

        public string TbEditHealth
        {
            get => tbEditHealth.Text;

            set
            {
                tbEditHealth.Text = value;
            }
        }

        #endregion Textboxes

        #region Buttons

        public bool BtnEditIsEnabled
        {
            get => btnEdit.Enabled;

            set
            {
                btnEdit.Enabled = value;
            }
        }

        public bool BtnDelIsEnabled
        {
            get => btnDel.Enabled;

            set
            {
                btnDel.Enabled = value;
            }
        }

        #endregion Buttons

        #region Create errors

        public bool LabNameCError
        {
            get => labNameCError.Visible;

            set
            {
                labNameCError.Visible = value;
            }
        }

        public bool LabLvlCError
        {
            get => labLvlCError.Visible;

            set
            {
                labLvlCError.Visible = value;
            }
        }

        public bool LabGoldCError
        {
            get => labGoldCError.Visible;

            set
            {
                labGoldCError.Visible = value;
            }
        }

        public bool LabDmgCError
        {
            get => labDmgCError.Visible;

            set
            {
                labDmgCError.Visible = value;
            }
        }

        public bool LabDefCError
        {
            get => labDefCError.Visible;

            set
            {
                labDefCError.Visible = value;
            }
        }

        public bool LabHealthCError
        {
            get => labHealthCError.Visible;

            set
            {
                labHealthCError.Visible = value;
            }
        }

        #endregion Create errors

        #region Modify errors

        public bool LabNameMError
        {
            get => labNameMError.Visible;

            set
            {
                labNameMError.Visible = value;
            }
        }

        public bool LabLvlMError
        {
            get => labLvlMError.Visible;

            set
            {
                labLvlMError.Visible = value;
            }
        }

        public bool LabGoldMError
        {
            get => labGoldMError.Visible;

            set
            {
                labGoldMError.Visible = value;
            }
        }

        public bool LabDmgMError
        {
            get => labDmgMError.Visible;

            set
            {
                labDmgMError.Visible = value;
            }
        }

        public bool LabDefMError
        {
            get => labDefMError.Visible;

            set
            {
                labDefMError.Visible = value;
            }
        }

        public bool LabHealthMError
        {
            get => labHealthMError.Visible;

            set
            {
                labHealthMError.Visible = value;
            }
        }

        #endregion Modify errors

        public ListBox LbEnemies
        {
            get => lbEnemies;
        }

        public Timer TimHideCreate
        {
            get => timHideCreate;
        }

        public Timer TimHideEdit
        {
            get => timHideEdit;
        }

        public Label LabEnemyCreate
        {
            get => labEnemyAdd;
        }

        public Label LabEnemyEdit
        {
            get => labEnemyEdit;
        }

        #endregion Properties

        public AdminEnemies()
        {
            InitializeComponent();
            _presenter = new AdminEnemiesPresenter(this);
        }

        #region Methods

        public void LoadData()
        {
            _presenter.LoadData();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (_presenter.AreCInputsValid())
            {
                _presenter.CreateEnemy();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_presenter.AreMInputsValid())
            {
                _presenter.EditEnemy();
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            _presenter.DeleteEnemy();
        }

        private void TimHideCreate_Tick(object sender, EventArgs e)
        {
            LabEnemyCreate.Visible = false;
            TimHideCreate.Stop();
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

        #endregion Methods
    }
}