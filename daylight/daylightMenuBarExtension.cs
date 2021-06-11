using CairoDesktop.Infrastructure.ObjectModel;
using System.Windows.Controls;
using CairoDesktop.Application.Interfaces;

namespace daylight
{
    class daylightMenuBarExtension : UserControlMenuBarExtension
    {
        public override UserControl StartControl(IMenuBar menuBar)
        {
            return new daylightMenu();
        }
    }
}