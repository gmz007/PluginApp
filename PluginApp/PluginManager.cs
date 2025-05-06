using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using PluginApp.Sdk;

namespace PluginApp
{
    public class PluginManager
    {
        [ImportMany]
        public IEnumerable<Lazy<IPlugin, IPluginMetadata>> Plugins { get; set; } = [];

        public PluginManager(string pluginPath)
        {
            Directory.CreateDirectory(pluginPath);

            var catalog = new AggregateCatalog();

            foreach (var dir in Directory.GetDirectories(pluginPath))
            {
                catalog.Catalogs.Add(new DirectoryCatalog(dir));
            }

            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}
