using CairoDesktop.Application.Interfaces;
using CairoDesktop.Infrastructure.ObjectModel;

namespace daylight
{
    public sealed class daylightExtension : IShellExtension
    {
        private readonly ICairoApplication _cairoApplication;
        private UserControlMenuBarExtension _daylightMenuBarExtension;

        public daylightExtension(ICairoApplication cairoApplication)
        {
            _cairoApplication = cairoApplication;
        }
        
        public void Start()
        {
            _daylightMenuBarExtension = new daylightMenuBarExtension();
            _cairoApplication.MenuBarExtensions.Add(_daylightMenuBarExtension);
        }

        public void Stop()
        {
            _cairoApplication.MenuBarExtensions.Remove(_daylightMenuBarExtension);
            _daylightMenuBarExtension = null;
        }
    }
}