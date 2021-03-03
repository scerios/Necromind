using System;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class AdminControls : UserControl
    {
        public event EventHandler BtnMapsClick;

        public event EventHandler BtnLocationsClick;

        public event EventHandler BtnHeroesClick;

        public event EventHandler BtnVendorsClick;

        public event EventHandler BtnEnemiesClick;

        public AdminControls()
        {
            InitializeComponent();
        }

        private void BtnMaps_Click(object sender, EventArgs e)
        {
            BtnMapsClick?.Invoke(this, e);
        }

        private void BtnLocations_Click(object sender, EventArgs e)
        {
            BtnLocationsClick?.Invoke(this, e);
        }

        private void BtnHeroes_Click(object sender, EventArgs e)
        {
            BtnHeroesClick?.Invoke(this, e);
        }

        private void BtnVendors_Click(object sender, EventArgs e)
        {
            BtnVendorsClick?.Invoke(this, e);
        }

        private void BtnEnemies_Click(object sender, EventArgs e)
        {
            BtnEnemiesClick?.Invoke(this, e);
        }
    }
}