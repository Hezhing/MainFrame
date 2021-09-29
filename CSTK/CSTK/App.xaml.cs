using CSTK.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace CSTK
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


        //添加Module引用
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            moduleCatalog.AddModule<MenuMoudle.MenuMoudleModule>();
            moduleCatalog.AddModule<ToolBarModule.ToolBarModuleModule>();
            moduleCatalog.AddModule<TreeViewModule.TreeViewModuleModule>();
            moduleCatalog.AddModule<WindowsModule.WindowsModuleModule>();
            
        }
    }
}
