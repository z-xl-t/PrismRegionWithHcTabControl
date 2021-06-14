using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using System.Diagnostics;

namespace RegionWithHcTabControl.ViewModels
{
    public class ViewCViewModel: BindableBase, IViewName, INavigationAware
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
            int? count = (navigationContext.Parameters["currentCount"] as int?);
            if (count != null)
            {
                Count = (int)count;

            }
        }
    }
}
