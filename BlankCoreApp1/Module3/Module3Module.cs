using Module3.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Module3
{
    public class Module3Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var manager = containerProvider.Resolve<IRegionManager>();

            manager.RegisterViewWithRegion("ContentRegion3", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}