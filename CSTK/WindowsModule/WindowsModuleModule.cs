using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WindowsModule.Views;

namespace WindowsModule
{
    public class WindowsModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var manager = containerProvider.Resolve<IRegionManager>();

            manager.RegisterViewWithRegion("WindowsContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}