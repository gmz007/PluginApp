using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using PluginApp.Sdk;

namespace PluginApp.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<Lazy<IPlugin, IPluginMetadata>> Plugins { get; set; }

        private Lazy<IPlugin, IPluginMetadata>? _selectedPlugin;

        public Lazy<IPlugin, IPluginMetadata>? SelectedPlugin
        {
            get => _selectedPlugin;
            set => SetProperty(ref _selectedPlugin, value);
        }

        public MainViewModel(PluginManager pluginManager)
        {
            Plugins = [.. pluginManager.Plugins];
        }

        public void ExecutePlugin()
        {
            SelectedPlugin?.Value.Execute();
        }
    }
}
