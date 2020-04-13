# Cairo Extension Samples
Example extensions for [Cairo Desktop Environment](https://cairodesktop.com)

## Weather
A sample menu extra extension that shows the current weather at your location. Uses the [OpenWeatherMap](https://openweathermap.org/) API and Windows Location API.

### Usage
1. Add `Weather.dll` to your Cairo Extensions directory. If you build and run with Visual Studio, this is done automatically.
2. Start (or restart) Cairo.
3. The weather menu will say "API key required". Click this and choose Settings.
4. Enter your OpenWeatherMap API key, and click "Open Windows location settings" to ensure location is enabled.
  - To obtain an API key, [sign up here for free](https://home.openweathermap.org/users/sign_up) and it will be emailed to you
5. Close weather settings, and now there will be weather in your menu bar, updated every 15 minutes. Click it for more details.