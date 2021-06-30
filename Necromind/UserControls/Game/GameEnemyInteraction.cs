using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Game
{
    public partial class GameEnemyInteraction : UserControl
    {
        public event EventHandler OnAttack;

        public event EventHandler OnRetreat;

        public event EventHandler OnFortify;

        public GameEnemyInteraction()
        {
            InitializeComponent();
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            OnAttack?.Invoke(this, e);
        }

        private void BtnRetreat_Click(object sender, EventArgs e)
        {
            OnRetreat?.Invoke(this, e);
        }

        private void BtnFortify_Click(object sender, EventArgs e)
        {
            OnFortify?.Invoke(this, e);
        }
    }
}