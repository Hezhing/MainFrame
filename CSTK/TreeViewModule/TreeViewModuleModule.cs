using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TreeViewModule.Views;

namespace TreeViewModule
{
    public class TreeViewModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var manager = containerProvider.Resolve<IRegionManager>();

            manager.RegisterViewWithRegion("TreeViewContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}