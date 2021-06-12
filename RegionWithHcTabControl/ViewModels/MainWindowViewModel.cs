using Prism.Commands;
using RegionWithHcTabControl.Helpers;
using RegionWithHcTabControl.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionWithHcTabControl.ViewModels
{
    public class MainWindowViewModel
    {
        public DelegateCommand<string> OpenTabControlCommand { get; set; }

        public MainWindowViewModel()
        {
            OpenTabControlCommand = new DelegateCommand<string>(OpenTabControl);


        }

        private void OpenTabControl(string viewName)
        {
            Dictionary<string, Type> dic = new Dictionary<string, Type>
            {
                {  "ViewA", typeof(ViewA) },
                {  "ViewAA", typeof(ViewA) },
                { "ViewB", typeof(ViewB) }
            };
            GlobalHelper.SwitchOrAddTab(viewName, dic[viewName]);
        }
    }
}
