using NecromindUI.Presenters.Admin;
using NecromindUI.Views.Admin;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminMap : UserControl, IAdminMap
    {
        #region Properties

        private readonly AdminMapPresenter _presenter;

        public string LabX
        {
            get => labXValue.Text;

            set
            {
                labXValue.Text = value;
            }
        }

        public string LabY
        {
            get => labYValue.Text;

            set
            {
                labYValue.Text = value;
            }
        }

        public string LabLocName
        {
            get => labLocNameValue.Text;

            set
            {
                labLocNameValue.Text = value;
            }
        }

        public string LabLocDescription
        {
            get => labLocDescriptionValue.Text;

            set
            {
                labLocDescriptionValue.Text = value;
            }
        }

        public string TbJumpX
        {
            get => tbJumpX.Text;

            set
            {
                tbJumpX.Text = value;
            }
        }

        public string TbJumpY
        {
            get => tbJumpY.Text;

            set
            {
                tbJumpY.Text = value;
            }
        }

        public bool LabIsAccessible
        {
            set
            {
                if (value)
                {
                    labAccessibleCross.Visible = false;
                    labAccessibleTick.Visible = true;
                }
                else
                {
                    labAccessibleTick.Visible = false;
                    labAccessibleCross.Visible = true;
                }
            }
        }

        public bool LabIsHostile
        {
            set
            {
                if (value)
                {
                    labHostileCross.Visible = false;
                    labHostileTick.Visible = true;
                }
                else
                {
                    labHostileTick.Visible = false;
                    labHostileCross.Visible = true;
                }
            }
        }

        public ListBox LbLocations
        {
            get => lbLocations;
        }

        #endregion Properties

        public AdminMap()
        {
            InitializeComponent();
            _presenter = new AdminMapPresenter(this);
        }

        public void LoadData()
        {
            _presenter.LoadData();
        }

        private void LbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.GetSelectedLocationStats();
        }
    }
}