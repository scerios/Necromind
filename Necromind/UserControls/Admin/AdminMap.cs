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

        #region Label

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

        #endregion Label

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

        public bool IndicatorsOff
        {
            set
            {
                labAccessibleCross.Visible = false;
                labAccessibleTick.Visible = false;
                labHostileCross.Visible = false;
                labHostileTick.Visible = false;
            }
        }

        #region Button

        public bool BtnIsNorthEnabled
        {
            get => btnNorth.Enabled;

            set
            {
                btnNorth.Enabled = value;
            }
        }

        public bool BtnIsSouthEnabled
        {
            get => btnSouth.Enabled;

            set
            {
                btnSouth.Enabled = value;
            }
        }

        public bool BtnIsWestEnabled
        {
            get => btnWest.Enabled;

            set
            {
                btnWest.Enabled = value;
            }
        }

        public bool BtnIsEastEnabled
        {
            get => btnEast.Enabled;

            set
            {
                btnEast.Enabled = value;
            }
        }

        public bool BtnIsAttachEnabled
        {
            get => btnAttach.Enabled;

            set
            {
                btnAttach.Enabled = value;
            }
        }

        public bool BtnIsDetachEnabled
        {
            get => btnDetach.Enabled;

            set
            {
                btnDetach.Enabled = value;
            }
        }

        public bool BtnIsSaveEnabled
        {
            get => btnSave.Enabled;

            set
            {
                btnSave.Enabled = value;
            }
        }

        public bool BtnIsDelEnabled
        {
            get => btnDel.Enabled;

            set
            {
                btnDel.Enabled = value;
            }
        }

        #endregion Button

        public Label LabMapEdit
        {
            get => labMapEdit;
        }

        public ListBox LbLocations
        {
            get => lbLocations;
        }

        public Timer TimMap
        {
            get => TimMap;
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
            _presenter.SetSelectedLocationStats();
        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {
            _presenter.MoveNorth();
        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {
            _presenter.MoveSouth();
        }

        private void BtnWest_Click(object sender, EventArgs e)
        {
            _presenter.MoveWest();
        }

        private void BtnEast_Click(object sender, EventArgs e)
        {
            _presenter.MoveEast();
        }

        private void BtnAttach_Click(object sender, EventArgs e)
        {
            _presenter.AttachLocation();
        }

        private void BtnDetach_Click(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void TimHide_Tick(object sender, EventArgs e)
        {
            LabMapEdit.Visible = false;
            TimMap.Stop();
        }
    }
}