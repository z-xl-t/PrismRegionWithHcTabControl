using Prism.Ioc;
using Prism.Regions;
using RegionWithHcTabControl.Helpers;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRegionManager regionManager;
        private readonly IContainerExtension container;

        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {

            base.OnSourceInitialized(e);
            // 添加依赖，用于去切换页面

            GlobalHelper.SetSwitchOrAddTabItemdependency(regionManager, MainTabControl);

            // GlobalHelper.SwitchOrAddTab("ViewA", typeof(ViewA));
        }
    }
}
