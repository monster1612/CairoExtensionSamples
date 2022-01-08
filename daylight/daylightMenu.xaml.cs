using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace daylight
{
    /// <summary>
    /// Interaction logic for daylightMenu.xaml
    /// </summary>
    public partial class daylightMenu : UserControl
    {
        public daylightMenu()
        {
            InitializeComponent();
        }

        private void SettingsMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            daylightSettings.Instance.Show();
            daylightSettings.Instance.Activate();
        }
    }
}
