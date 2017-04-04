using Microsoft.Practices.Unity;
using Prism.Unity;
using System.Windows;
using ExampleModule;
using Prism.Modularity;


namespace WpfPrismExample
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ModuleSample));
        }
    }
}
