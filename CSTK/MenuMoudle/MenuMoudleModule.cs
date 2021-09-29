using MenuMoudle.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MenuMoudle
{
    public class MenuMoudleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var manager = containerProvider.Resolve<IRegionManager>();

            manager.RegisterViewWithRegion("MenuContentRegion", typeof(ViewA));

        }
         
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}