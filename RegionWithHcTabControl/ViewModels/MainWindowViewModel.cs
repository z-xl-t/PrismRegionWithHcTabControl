using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using RegionWithHcTabControl.Helpers;
using RegionWithHcTabControl.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionWithHcTabControl.ViewModels
{
    public class MainWindowViewModel: BindableBase
    {

        private int currentCOunt;

        public int CurrentCount
        {
            get { return currentCOunt; }
            set { SetProperty(ref currentCOunt, value); }
        }


        public DelegateCommand<string> OpenTabControlCommand { get; set; }

        public DelegateCommand<string> OpenTabControlWithParametersCommand { get; set; }

        public MainWindowViewModel()
        {
            OpenTabControlCommand = new DelegateCommand<string>(OpenTabControl);

            OpenTabControlWithParametersCommand = new DelegateCommand<string>(OpenTabControlWithParameters);
        }

        private void OpenTabControlWithParameters(string type)
        {
            CurrentCount++;
            var parameters = new NavigationParameters();
            parameters.Add("currentCount", CurrentCount);

            if (type == "aaa")
            {
                TabSwitchOrAddHelper.SwitchOrAddTab($"ViewC-aaa", typeof(ViewC), parameters);

            }
            if (type == "bbb")
            {
                TabSwitchOrAddHelper.SwitchOrAddTab($"ViewC-bbb-{CurrentCount}", typeof(ViewC), parameters);
            }
        }

        private void OpenTabControl(string viewName)
        {
            Dictionary<string, Type> dic = new Dictionary<string, Type>
            {
                {  "ViewA", typeof(ViewA) },
                {  "ViewAA", typeof(ViewA) },
                {  "ViewB", typeof(ViewB) },
                { "ViewC", typeof(ViewC) },
            };
            TabSwitchOrAddHelper.SwitchOrAddTab(viewName, dic[viewName]);
        }
    }
}