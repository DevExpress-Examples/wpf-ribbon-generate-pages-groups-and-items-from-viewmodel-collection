<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/Q521663/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/Q521663/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/Q521663/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Q521663/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/Q521663/ViewModel.cs) (VB: [ViewModel.vb](./VB/Q521663/ViewModel.vb))
<!-- default file list end -->
# How to generate Ribbon pages, groups and items based on a view model collection


<p>This example demonstrates how to generate pages, groups and items from a collection according to the MVVM pattern. To generate pages in the RibbonPageCategory, bind the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfRibbonRibbonPageCategoryBase_PagesSourcetopic"><u>PagesSource</u></a> property to a collection. Use the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfRibbonRibbonPageCategoryBase_PageTemplatetopic"><u>PageTemplate</u></a> property to specify a template for generated pages.</p><p>RibbonPage and RibbonPageGroup contain similar properties for generating groups and bar items:</p><p>- <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfRibbonRibbonPage_GroupsSourcetopic"><u>GroupsSource</u></a>, <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfRibbonRibbonPage_GroupTemplatetopic"><u>GroupTemplate</u></a></p><p>- <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfRibbonRibbonPageGroup_ItemLinksSourcetopic"><u>ItemLinksSource</u></a>, <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfRibbonRibbonPageGroup_ItemTemplatetopic"><u>ItemTemplate</u></a></p>

<br/>


