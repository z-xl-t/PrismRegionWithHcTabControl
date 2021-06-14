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
    public class ViewCViewModel: BindableBase, INavigationAware, IRegionMemberLifetime
    {
        private string viewName;

        public string ViewName
        {
            get { return viewName; }
            set { SetProperty(ref viewName, value); }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { SetProperty(ref count, value); }
        }

        public bool KeepAlive => false;

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {

            Debug.WriteLine("ViewC-IsNavigationTarget");
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

            Debug.WriteLine("ViewC-OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

            Debug.WriteLine("ViewC-OnNavigatedTo");
            int? count = (navigationContext.Parameters["currentCount"] as int?);
            if (count != null)
            {
                Count = (int)count;

            }
        }
    }
}
