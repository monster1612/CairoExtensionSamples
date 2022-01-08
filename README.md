# Cairo Extension Samples
Example extensions for [Cairo Desktop Environment](https://cairodesktop.com). Cairo extensions should be installed to the `%localappdata%\Cairo_Development_Team\Extensions` directory.

---

# unique extensions

## Daylight **(currently WIP)**
prevents the screen from going to sleep for a specific length of time, similar to [PowerToys Awake](https://docs.microsoft.com/en-us/windows/powertoys/awake).

### usage
* TBD: currently a work in progress.

### attributions
* this specific extension makes use of a modified version of the "half-moon" icon from the [Iconoir](https://iconoir.com/) library, which is released under the [MIT license](https://github.com/lucaburgio/iconoir/blob/master/LICENSE).
* this extension is also based on the Weather extension (see below) and borrows code from the main Cairo project for implementation of the "icon" placement.
---

# upstream extensions from the Cairo development team follow below.


## Places.ShellFolders
Adds additional shell folder locations to the Places menu.

### Usage
1. Add `Places.ShellFolders.dll` to your Cairo `Extensions` directory. If you build and run with Visual Studio, this is done automatically.
2. Start (or restart) Cairo.

## Weather
A sample menu extra extension that shows the current weather at your location. Uses the [OpenWeatherMap](https://openweathermap.org/) API and Windows Location API.

### Usage
1. Add `Weather.dll` to your Cairo `Extensions` directory. If you build and run with Visual Studio, this is done automatically.
2. Start (or restart) Cairo.
3. The weather menu will say "API key required". Click this and choose Settings.
4. Enter your OpenWeatherMap API key, and click "Open Windows location settings" to ensure location is enabled.
  - To obtain an API key, [sign up here for free](https://home.openweathermap.org/users/sign_up) and it will be emailed to you
5. Close weather settings, and now there will be weather in your menu bar, updated every 15 minutes. Click it for more details.

## Widget
A sample floating window that loads with Cairo.

### Usage
1. Add `Widget.dll` to your Cairo `Extensions` directory. If you build and run with Visual Studio, this is done automatically.
2. Start (or restart) Cairo.