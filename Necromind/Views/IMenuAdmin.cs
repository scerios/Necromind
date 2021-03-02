using System.Windows.Forms;

namespace Necromind.Views
{
    public interface IMenuAdmin
    {
        string Password { get; set; }
        Panel PanControls { get; }
        Panel PanSettings { get; }
    }
}