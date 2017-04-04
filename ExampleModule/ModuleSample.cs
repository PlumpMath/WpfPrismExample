using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;
using ExampleModule.Views;

namespace ExampleModule
{
    public class ModuleSample : IModule
    {
        IRegionManager _regionManager;

        public ModuleSample(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(UserList));
        }
    }
}
