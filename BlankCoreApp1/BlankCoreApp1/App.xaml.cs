using BlankCoreApp1.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace BlankCoreApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            moduleCatalog.AddModule<Module1.Module1Module>();
            moduleCatalog.AddModule<Module2.Module2Module>();
            moduleCatalog.AddModule<Module3.Module3Module>();
            moduleCatalog.AddModule<Module4.Module4Module>();
        }
    }
}
