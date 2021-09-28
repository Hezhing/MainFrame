using Module4.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Module4
{
    public class Module4Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var manager = containerProvider.Resolve<IRegionManager>();

            manager.RegisterViewWithRegion("ContentRegion4", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}