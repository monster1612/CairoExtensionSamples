using System.ComponentModel;
using System.Windows;
using ManagedShell.Common.Helpers;

namespace daylight
{
    /// <summary>
    /// Interaction logic for daylightSettings.xaml
    /// </summary>
    public partial class daylightSettings : Window
    {
        private static daylightSettings _instance = null;

        public static daylightSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new daylightSettings();
                }

                return _instance;
            }
        }

        public daylightSettings()
        {
            InitializeComponent();

            //ApiKeyTextBox.Text = Properties.Settings.Default.ApiKey;

            chkAlwaysShowTime.IsChecked = Properties.Settings.Default.ShowTimeLeft;

            if (Properties.Settings.Default.ShowTimeLeft == false)
                chkShowSecondsInTime.IsEnabled = false;

            chkShowSecondsInTime.IsChecked = Properties.Settings.Default.ShowSecondsInTime;

            //if (!EnvironmentHelper.IsWindows10OrBetter)
            //{
            //    LocationSettingsStackPanel.Visibility = Visibility.Collapsed;
            //}
        }

        private void daylightSettings_OnClosing(object sender, CancelEventArgs e)
        {
            //Properties.Settings.Default.ApiKey = ApiKeyTextBox.Text;

            Properties.Settings.Default.ShowTimeLeft = chkAlwaysShowTime.IsChecked.Value;

            Properties.Settings.Default.Save();

            _instance = null;
        }

        private void OpenLocationSettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            ShellHelper.ExecuteProcess("ms-settings:privacy-location");
        }
    }
}
