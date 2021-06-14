using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionWithHcTabControl.ViewModels
{
    public class ViewBViewModel : BindableBase, INavigationAware
    {
        public ViewBViewModel()
        {

        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Debug.WriteLine("ViewB");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}
