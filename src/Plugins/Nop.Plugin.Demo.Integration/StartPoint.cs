using System.Threading.Tasks;
using Nop.Core;
using Nop.Services.Common;
using Nop.Services.Plugins;

namespace Nop.Plugin.Demo.Integration;

public class StartPoint: IMiscPlugin
{
    private IWebHelper _webHelper;

    public string GetConfigurationPageUrl()
    {
        return $"{_webHelper.GetStoreLocation()}Admin/DemoIntegrationController/Configure";
    }

    public PluginDescriptor PluginDescriptor { get; set; }
    public Task InstallAsync()
    {
        throw new System.NotImplementedException();
    }

    public Task UninstallAsync()
    {
        throw new System.NotImplementedException();
    }

    public Task UpdateAsync(string currentVersion, string targetVersion)
    {
        throw new System.NotImplementedException();
    }

    public Task PreparePluginToUninstallAsync()
    {
        throw new System.NotImplementedException();
    }
}