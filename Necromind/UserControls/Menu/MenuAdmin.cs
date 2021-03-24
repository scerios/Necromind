using Necromind.Presenters.Menu;
using Necromind.Views.Menu;
using NecromindUI.UserControls.Admin;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Menu
{
    public partial class MenuAdmin : UserControl, IMenuAdmin
    {
        private readonly MenuAdminPresenter _presenter;
        private readonly AdminControls _controls;
        private readonly AdminHeroes _adminHeroes;
        private readonly AdminEnemies _adminEnemies;

        public string Password
        {
            get => tbPassword.Text;

            set
            {
                tbPassword.Text = value;
            }
        }

        public Panel PanControls
        {
            get => panControls;
        }

        public Panel PanSettings
        {
            get => panSettings;
        }

        public event EventHandler BtnBackCLick;

        public MenuAdmin()
        {
            InitializeComponent();
            _presenter = new MenuAdminPresenter(this);
            _controls = new AdminControls();
            _adminHeroes = new AdminHeroes();
            _adminEnemies = new AdminEnemies();
        }

        private void LoadViews()
        {
            LoadView(PanSettings, _adminHeroes);
            LoadView(PanSettings, _adminEnemies);
        }

        private void SetControlsEvents()
        {
            _controls.BtnMapsClick += new EventHandler(AdminControls_BtnMapsClick);
            _controls.BtnLocationsClick += new EventHandler(AdminControls_BtnLocationsClick);
            _controls.BtnHeroesClick += new EventHandler(AdminControls_BtnHeroesClick);
            _controls.BtnEnemiesClick += new EventHandler(AdminControls_BtnEnemiesClick);
        }

        private void TbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEnter_Click(this, e);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BtnBackCLick?.Invoke(this, e);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (_presenter.IsPasswordCorrect())
            {
                ActivateView(PanControls, _controls);
                LoadViews();
                SetControlsEvents();
            }

            Password = "";
        }

        private void ActivateView(Panel panel, UserControl view)
        {
            panel.Controls.Add(view);
            view.BringToFront();
        }

        private void LoadView(Panel panel, UserControl view)
        {
            panel.Controls.Add(view);
        }

        private void BringToFront(UserControl view)
        {
            view.BringToFront();
        }

        private void AdminControls_BtnMapsClick(object sender, EventArgs e)
        {
            // TODO - Create settings panel for maps.
        }

        private void AdminControls_BtnLocationsClick(object sender, EventArgs e)
        {
            // TODO - Create settings panel for locations.
        }

        private void AdminControls_BtnHeroesClick(object sender, EventArgs e)
        {
            BringToFront(_adminHeroes);
        }

        private void AdminControls_BtnVendorsClick(object sender, EventArgs e)
        {
            // TODO - Create settings panel for vendors.
        }

        private void AdminControls_BtnEnemiesClick(object sender, EventArgs e)
        {
            BringToFront(_adminEnemies);
        }
    }
}