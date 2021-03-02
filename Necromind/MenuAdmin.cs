using Necromind.Presenters;
using Necromind.Views;
using System;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class MenuAdmin : UserControl, IMenuAdmin
    {
        private readonly MenuAdminPresenter _presenter;
        private readonly AdminControls _controls;

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
            tbPassword.Focus();
        }

        private void ActivateView(Panel panel, UserControl view)
        {
            panel.Controls.Add(view);
            view.BringToFront();
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
            }

            Password = "";
        }
    }
}