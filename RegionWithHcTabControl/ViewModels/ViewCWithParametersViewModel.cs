using Prism.Commands;
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
    public class ViewCWithParametersViewModel : BindableBase, INavigationAware
    {

        private int currentCount;

        public int CurrentCount
        {
            get { return currentCount; }
            set { SetProperty(ref currentCount, value); }
        }

        public ViewCWithParametersViewModel()
        {

        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Debug.WriteLine("ViewC");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

            int? count = (navigationContext.Parameters["currentCount"] as int?);
            if (count != null)
            {
                CurrentCount = (int)count;

            }
        }
    }
}
