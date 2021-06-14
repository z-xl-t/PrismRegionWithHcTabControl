using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using RegionWithHcTabControl.Helpers;
using RegionWithHcTabControl.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionWithHcTabControl.ViewModels
{
    public class ViewAViewModel: BindableBase, INavigationAware
    {
        public ViewAViewModel(IRegionManager regionManager, IContainerExtension container)
        {
            Console.WriteLine("111");

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {

            Debug.WriteLine("ViewA-IsNavigationTarget");
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Debug.WriteLine("ViewA-OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

            Debug.WriteLine("ViewA-OnNavigatedTo");
        }
    }
}
