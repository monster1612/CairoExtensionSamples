using System.ComponentModel.Composition;
using CairoDesktop.Application.Interfaces;

namespace daylight
{
    [Export(typeof(IDependencyRegistrant))]
    public class DependencyRegistrant : IDependencyRegistrant
    {
        public void Register(IDependencyRegistrar registrar)
        {
            registrar.AddSingleton<IShellExtension, daylightExtension>();
        }
    }
}