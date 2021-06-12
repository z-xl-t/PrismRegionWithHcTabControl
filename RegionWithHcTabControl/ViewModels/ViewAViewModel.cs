using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionWithHcTabControl.ViewModels
{
    public class ViewAViewModel
    {
        public ViewAViewModel(IRegionManager regionManager, IContainerExtension container)
        {
            Console.WriteLine("111");
        }
    }
}
