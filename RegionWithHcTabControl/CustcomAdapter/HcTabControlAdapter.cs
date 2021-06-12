using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TabControl = HandyControl.Controls.TabControl;
using TabItem = HandyControl.Controls.TabItem;

namespace RegionWithHcTabControl.CustcomAdapter
{
    public class HcTabControlAdapter : RegionAdapterBase<TabControl>
    {
        public HcTabControlAdapter(IRegionBehaviorFactory regionhaviorFactory) : base(regionhaviorFactory)
        {
        }
        protected override void Adapt(IRegion region, TabControl regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    // 这里其实就可以捕捉到加进来的 TabItem 的， 但是没必要
                    Debug.WriteLine("我被添加了");
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    //Debug.WriteLine("我被移除了");
                }
                else if (e.Action == NotifyCollectionChangedAction.Reset)
                {
                    //Debug.WriteLine("我被重置了");
                }
                else if (e.Action == NotifyCollectionChangedAction.Replace)
                {
                    //Debug.WriteLine("我被替换了");
                }
            };

        }

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
    }
}
