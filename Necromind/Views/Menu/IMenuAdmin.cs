using System.Windows.Forms;

namespace Necromind.Views.Menu
{
    public interface IMenuAdmin
    {
        string Password { get; set; }
        Panel PanControls { get; }
        Panel PanSettings { get; }
    }
}