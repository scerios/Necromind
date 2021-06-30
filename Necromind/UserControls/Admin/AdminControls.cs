using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminControls : UserControl
    {
        public event EventHandler OnMapClicked;

        public event EventHandler OnLocationsClicked;

        public event EventHandler OnHeroesClicked;

        public event EventHandler OnVendorsClicked;

        public event EventHandler OnEnemiesClicked;

        public AdminControls()
        {
            InitializeComponent();
        }

        private void BtnMaps_Click(object sender, EventArgs e)
        {
            OnMapClicked?.Invoke(this, e);
        }

        private void BtnLocations_Click(object sender, EventArgs e)
        {
            OnLocationsClicked?.Invoke(this, e);
        }

        private void BtnHeroes_Click(object sender, EventArgs e)
        {
            OnHeroesClicked?.Invoke(this, e);
        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {
            OnVendorsClicked?.Invoke(this, e);
        }

        private void BtnEnemies_Click(object sender, EventArgs e)
        {
            OnEnemiesClicked?.Invoke(this, e);
        }
    }
}