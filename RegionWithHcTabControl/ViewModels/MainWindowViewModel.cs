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

        public int CurrentCount { get; set; } = 0;
        public DelegateCommand<string> OpenTabControlCommand { get; set; }

        public DelegateCommand<string> OpenTabControlWithParametersCommand { get; set; }

        public MainWindowViewModel()
        {
            OpenTabControlCommand = new DelegateCommand<string>(OpenTabControl);

            OpenTabControlWithParametersCommand = new DelegateCommand<string>(OpenTabControlWithParameters);
        }

        private void OpenTabControlWithParameters(string flag)
        {
            CurrentCount++;

            var parameters = new NavigationParameters();
            parameters.Add("currentCount", CurrentCount);

            if (flag != "OpenNewTab")
            {

                TabSwitchOrAddHelper.SwitchOrAddTab("1", typeof(ViewCWithParameters), parameters);
            }
            else
            {
                TabSwitchOrAddHelper.SwitchOrAddTab($"1-{CurrentCount}", typeof(ViewCWithParameters), parameters);
            }
        }

        private void OpenTabControl(string viewName)
        {
            Dictionary<string, Type> dic = new Dictionary<string, Type>
            {
                {  "ViewA", typeof(ViewA) },
                {  "ViewAA", typeof(ViewA) },
                {  "ViewB", typeof(ViewB) },
                { "ViewC", typeof(ViewCWithParameters) }
            };
            TabSwitchOrAddHelper.SwitchOrAddTab(viewName, dic[viewName]);
        }
    }
}