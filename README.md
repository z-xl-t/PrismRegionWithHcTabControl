
I'm trying to use [Prism](https://github.com/PrismLibrary/Prism) and [HandyControl](https://github.com/HandyOrg/HandyControl) to create a project, **but now I have a very strange problem.**

This is My Github repo:  [https://github.com/sanshiliuxiao/PrismRegionWithHcTabControl](https://github.com/sanshiliuxiao/PrismRegionWithHcTabControl)

(If you know Chinese, you can see the principle of my implementation) My Blog: [http://sanshiliuxiao.top/notebook/CSharp/20210611-PrismWithTabControl/](http://sanshiliuxiao.top/notebook/CSharp/20210611-PrismWithTabControl/)

I have three views (A, B, Cwithparameters) whose ViewModel inherits Inavigationaware. 


If I click  the button (`ViewA` or `ViewB`), It can execute three functions in turn (`OnNavigatedFrom`、`IsNavigationTarget`、`OnNavigatedTo`).

But, if I click the button (`ViewC`), it just execute the `OnNavigatedFrom`.


Why? It's so strange!!!

![3.gif](https://i.loli.net/2021/06/14/xmVyFgaXrfDY16T.gif)
![1.gif](https://i.loli.net/2021/06/14/uIhZfFlaeXWnHTL.gif)



## Fix  Inavigationaware  problem

ISSUSE: [The Inavigationaware Interface Problem, Why Just exec OnNavigatedFrom](https://github.com/PrismLibrary/Prism/issues/2480)


1. Create the `IViewName` interface

2. Modify function in `Prism.Regions.RegionNavigationContentLoader.cs`
    ```csharp
       private IEnumerable<object> GetCandidatesFromRegionViews(IRegion region, string candidateNavigationContract)
        {
            return region.Views.Where(v => ViewIsMatch(v, candidateNavigationContract));
            // return region.Views.Where(v => ViewIsMatch(v.GetType(), candidateNavigationContract));
        }

        private bool ViewIsMatch(object v, string navigationSegment)
        {

            var names = new List<string>() { v.GetType().Name, v.GetType().FullName, (v as IViewName)?.ViewName ?? string.Empty, ((v as FrameworkElement)?.DataContext as IViewName)?.ViewName ?? string.Empty };
            return names.Any(x => x.Equals(navigationSegment, StringComparison.Ordinal));
        }

        //private static bool ViewIsMatch(Type viewType, string navigationSegment)
        //{
        //    var names = new[] { viewType.Name, viewType.FullName };
        //    return names.Any(x => x.Equals(navigationSegment, StringComparison.Ordinal));
        //}
    ```
3. View or ViewModel to inherits the interface.

4. When  create a view, write  the ViewName, like `RegionWithHcTabControl.Helpers.TabSwitchOrAddHelper.cs`:
    ```csharp
        object content = System.Activator.CreateInstance(viewType);

        var v = ((content as FrameworkElement) as IViewName);
        if (v != null)
        {
            v.ViewName = viewName;

        }
        
        var vm = ((content as FrameworkElement)?.DataContext as IViewName);
        if (vm != null)
        {
            vm.ViewName = viewName;
        }
    ```