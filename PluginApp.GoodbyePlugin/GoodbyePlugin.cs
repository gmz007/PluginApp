
using System.ComponentModel.Composition;
using System.Windows;
using PluginApp.Sdk;

namespace PluginApp.Extension.GoodbyePlugin;

[Export(typeof(IPlugin))]
[ExportMetadata("Name", "Goodbye Plugin")]
[ExportMetadata("Description", "Plugin that shows a goodbye prompt.")]
public class GoodbyePlugin : IPlugin
{
    public void Execute()
    {
        MessageBox.Show("Goodbye! - from Goodbye Plugin.", "Goodbye Plugin", MessageBoxButton.OK, MessageBoxImage.Exclamation);
    }
}
