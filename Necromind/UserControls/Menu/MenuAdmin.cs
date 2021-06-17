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
        private AdminControls _controls;
        private AdminHeroes _adminHeroes;
        private AdminEnemies _adminEnemies;
        private AdminLocations _adminLocations;
        private AdminMap _adminMap;
        private UserControl _currentView;

        public string Password
        {
            get => tbPassword.Text;

            set
            {
                tbPassword.Text = value;
            }
        }

        public bool IsPanInfoPassVisible
        {
            get => panInfoPass.Visible;

            set
            {
                panInfoPass.Visible = value;
            }
        }

        public bool IsPanInfoConvVisible
        {
            get => panInfoConv.Visible;

            set
            {
                panInfoConv.Visible = value;
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
        }

        private void SetAdminLayer()
        {
            _controls = new AdminControls();
            _adminHeroes = new AdminHeroes();
            _adminEnemies = new AdminEnemies();
            _adminLocations = new AdminLocations();
            _adminMap = new AdminMap();
        }

        private void SetControlsEvents()
        {
            _controls.BtnHeroesClick += new EventHandler(AdminControls_BtnHeroesClick);
            _controls.BtnEnemiesClick += new EventHandler(AdminControls_BtnEnemiesClick);
            _controls.BtnLocationsClick += new EventHandler(AdminControls_BtnLocationsClick);
            _controls.BtnMapClick += new EventHandler(AdminControls_BtnMapClick);
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
                SetAdminLayer();
                SetControlsEvents();
                ActivateMainView(PanControls, _controls);
            }

            Password = "";
        }

        private void ActivateMainView(Panel panel, UserControl view)
        {
            panel.Controls.Add(view);
            view.BringToFront();
        }

        private void ActivateView(Panel panel, UserControl view)
        {
            if (_currentView != null)
            {
                panel.Controls.Remove(_currentView);
            }

            _currentView = view;
            panel.Controls.Add(_currentView);
            _currentView.BringToFront();
        }

        private void BringToFront(UserControl view)
        {
            view.BringToFront();
        }

        private void AdminControls_BtnMapClick(object sender, EventArgs e)
        {
            ActivateView(PanSettings, _adminMap);
            _adminMap.LoadData();
            BringToFront(_adminMap);
        }

        private void AdminControls_BtnLocationsClick(object sender, EventArgs e)
        {
            ActivateView(PanSettings, _adminLocations);
            _adminLocations.LoadData();
            BringToFront(_adminLocations);
        }

        private void AdminControls_BtnHeroesClick(object sender, EventArgs e)
        {
            ActivateView(PanSettings, _adminHeroes);
            _adminHeroes.LoadData();
            BringToFront(_adminHeroes);
        }

        private void AdminControls_BtnVendorsClick(object sender, EventArgs e)
        {
            // TODO - Create settings panel for vendors.
        }

        private void AdminControls_BtnEnemiesClick(object sender, EventArgs e)
        {
            ActivateView(PanSettings, _adminEnemies);
            _adminEnemies.LoadData();
            BringToFront(_adminEnemies);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if (_controls == null)
            {
                IsPanInfoPassVisible = true;
                panInfoPass.BringToFront();
            }
            else
            {
                IsPanInfoConvVisible = true;
                panInfoConv.BringToFront();
            }
        }

        private void BtnInfoPassClose_Click(object sender, EventArgs e)
        {
            IsPanInfoPassVisible = false;
        }

        private void BtnInfoConvClose_Click(object sender, EventArgs e)
        {
            IsPanInfoConvVisible = false;
        }
    }
}