using System.Windows;
using PluginApp.ViewModels;

namespace PluginApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        public MainViewModel MainViewModel { get; }

        public App()
        {
            var pluginManager = new PluginManager("Plugins");

            MainViewModel = new MainViewModel(pluginManager);
        }
    }
}
