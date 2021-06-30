using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Admin
{
    public partial class AdminControls : UserControl
    {
        public event EventHandler OnMapClick;

        public event EventHandler OnLocationsClick;

        public event EventHandler OnHeroesClick;

        public event EventHandler OnVendorsClick;

        public event EventHandler OnEnemiesClick;

        public AdminControls()
        {
            InitializeComponent();
        }

        private void BtnMaps_Click(object sender, EventArgs e)
        {
            OnMapClick?.Invoke(this, e);
        }

        private void BtnLocations_Click(object sender, EventArgs e)
        {
            OnLocationsClick?.Invoke(this, e);
        }

        private void BtnHeroes_Click(object sender, EventArgs e)
        {
            OnHeroesClick?.Invoke(this, e);
        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {
            OnVendorsClick?.Invoke(this, e);
        }

        private void BtnEnemies_Click(object sender, EventArgs e)
        {
            OnEnemiesClick?.Invoke(this, e);
        }
    }
}