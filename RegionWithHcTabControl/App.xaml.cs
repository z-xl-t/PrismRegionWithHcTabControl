using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using RegionWithHcTabControl.CustcomAdapter;
using RegionWithHcTabControl.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RegionWithHcTabControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            // 创建主窗体
            Window w = Container.Resolve<MainWindow>();
            return w;


        }

       
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            // 设置 TabControl （此为 hc 的 TabControl 不是 WPF 自带的） 适配器
            regionAdapterMappings.RegisterMapping(typeof(HandyControl.Controls.TabControl), Container.Resolve<HcTabControlAdapter>());
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
            containerRegistry.RegisterForNavigation<ViewCWithParameters>();
        }
    }
}
