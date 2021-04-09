using NecromindUI.Presenters.Admin;
using NecromindUI.Views.Admin;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminHeroes : UserControl, IAdminHeroes
    {
        private readonly AdminHeroesPresenter _presenter;

        public string LabName
        {
            get => labNameValue.Text;
            set
            {
                labNameValue.Text = value;
            }
        }

        public string TbLvl
        {
            get => tbLvl.Text;

            set
            {
                tbLvl.Text = value;
            }
        }

        public string TbGold
        {
            get => tbGold.Text;

            set
            {
                tbGold.Text = value;
            }
        }

        public string TbDmgMin
        {
            get => tbDmgMin.Text;

            set
            {
                tbDmgMin.Text = value;
            }
        }

        public string TbDmgMax
        {
            get => tbDmgMax.Text;

            set
            {
                tbDmgMax.Text = value;
            }
        }

        public string TbDef
        {
            get => tbDef.Text;

            set
            {
                tbDef.Text = value;
            }
        }

        public string TbHealth
        {
            get => tbHealth.Text;

            set
            {
                tbHealth.Text = value;
            }
        }

        public ListBox LbHeroes
        {
            get => lbHeroes;
        }

        public Timer TimHide
        {
            get => timHide;
        }

        public Label LabHeroEdit
        {
            get => labHeroEdit;
        }

        public AdminHeroes()
        {
            InitializeComponent();
            _presenter = new AdminHeroesPresenter(this);
        }

        public void LoadData()
        {
            _presenter.LoadData();
        }

        private void LbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.GetSelectedHeroStats();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _presenter.EditHero();
        }

        private void TimHide_Tick(object sender, EventArgs e)
        {
            labHeroEdit.Visible = false;
            timHide.Stop();
        }
    }
}