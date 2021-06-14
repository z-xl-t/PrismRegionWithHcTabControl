
using Prism.Mvvm;
using Prism.Navigation;
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
    public class ViewBViewModel : BindableBase, IViewName, INavigationAware
    {
        private string viewName;

        public string ViewName
        {
            get { return viewName; }
            set { SetProperty(ref viewName, value); }
        }

        public ViewBViewModel()
        {
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {

            Debug.WriteLine($"{ViewName}-IsNavigationTarget");
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Debug.WriteLine($"{ViewName}-OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

            Debug.WriteLine($"{ViewName}-OnNavigatedTo");
        }
    }
}
