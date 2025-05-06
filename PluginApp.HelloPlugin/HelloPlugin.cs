using System.ComponentModel.Composition;
using System.Windows;
using PluginApp.Sdk;

namespace PluginApp.Extension.HelloPlugin;

[Export(typeof(IPlugin))]
[ExportMetadata("Name", "Hello Plugin")]
[ExportMetadata("Description", "Plugin that shows a hello prompt.")]
public class HelloPlugin : IPlugin
{
    public void Execute()
    {
        MessageBox.Show("Hello! - from Hello Plugin.", "Hello Plugin", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
