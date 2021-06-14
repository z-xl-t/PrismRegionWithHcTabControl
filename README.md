
I'm trying to use [Prism](https://github.com/PrismLibrary/Prism) and [HandyControl](https://github.com/HandyOrg/HandyControl) to create a project, **but now I have a very strange problem.**

This is My Github repo:  [https://github.com/sanshiliuxiao/PrismRegionWithHcTabControl](https://github.com/sanshiliuxiao/PrismRegionWithHcTabControl)

(If you know Chinese, you can see the principle of my implementation) My Blog: [http://sanshiliuxiao.top/notebook/CSharp/20210611-PrismWithTabControl/](http://sanshiliuxiao.top/notebook/CSharp/20210611-PrismWithTabControl/)

I have three views (A, B, Cwithparameters) whose ViewModel inherits Inavigationaware. 


If I click  the button (`ViewA` or `ViewB`), It can execute three functions in turn (`OnNavigatedFrom`、`IsNavigationTarget`、`OnNavigatedTo`).

But, if I click the button (`ViewC`), it just execute the `OnNavigatedFrom`.


Why? It's so strange!!!

This gif image. 


![2.gif](https://i.loli.net/2021/06/14/GyHOTLRDmbwhlV5.gif)
![3.gif](https://i.loli.net/2021/06/14/xmVyFgaXrfDY16T.gif)
![1.gif](https://i.loli.net/2021/06/14/uIhZfFlaeXWnHTL.gif)


