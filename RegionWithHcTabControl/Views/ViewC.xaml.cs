using RegionWithHcTabControl.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegionWithHcTabControl.Views
{
    /// <summary>
    /// ViewC.xaml 的交互逻辑
    /// </summary>
    public partial class ViewC : UserControl, IViewName
    {
        public string ViewName { get; set; } = nameof(ViewC);
        public ViewC()
        {
            InitializeComponent();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            var vm = DataContext as ViewCViewModel;
            vm.ViewName = ViewName;
        }
    }
}
