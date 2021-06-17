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
                labLocName.Text = value;
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

        public bool LabAccessibleTick
        {
            get => labAccessibleTick.Visible;

            set
            {
                labAccessibleTick.Visible = value;
            }
        }

        public bool LabAccessibleCross
        {
            get => labAccessibleCross.Visible;

            set
            {
                labAccessibleCross.Visible = value;
            }
        }

        public bool LabHostileTick
        {
            get => labHostileTick.Visible;

            set
            {
                labHostileTick.Visible = value;
            }
        }

        public bool LabHostileCross
        {
            get => labHostileCross.Visible;

            set
            {
                labHostileCross.Visible = value;
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
    }
}