using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using ToolBarModule.Views;

namespace ToolBarModule
{
    public class ToolBarModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var manager = containerProvider.Resolve<IRegionManager>();

            manager.RegisterViewWithRegion("ToolBarContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}