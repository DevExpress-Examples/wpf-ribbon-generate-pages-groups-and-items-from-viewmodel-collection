<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655557/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5215)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Ribbon - Generate Pages, Groups, and Items from a ViewModel Collection

This example generates ribbon pages ([RibbonPage](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPage)), groups ([RibbonPageGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPageGroup)), and items ([BarButtonItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarButtonItem)) from a View Model collection:

![image](https://github.com/DevExpress-Examples/wpf-ribbon-generate-pages-groups-and-items-from-viewmodel-collection/assets/65009440/49d2f725-0ec0-4af8-b315-f78b353a21ac)

To generate pages in the [RibbonPageCategory](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPageCategory), bind the [RibbonPageCategoryBase.PagesSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPageCategoryBase.PagesSource) property to a collection. Use the [RibbonPageCategoryBase.PageTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPageCategoryBase.PageTemplate) property to specify a template for generated pages.

The [RibbonPage](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPage) and [RibbonPageGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPageGroup) contain similar properties that allow you to generate groups and bar items:

* [RibbonPage.GroupsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPage.GroupsSource), [RibbonPage.GroupTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPage.GroupTemplate)
* [RibbonPageGroup.ItemLinksSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPageGroup.ItemLinksSource), [RibbonPageGroup.ItemTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonPageGroup.ItemTemplate)

## Files to Review

* [MainWindow.xaml](./CS/Q521663/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Q521663/MainWindow.xaml))
* [ViewModel.cs](./CS/Q521663/ViewModel.cs) (VB: [ViewModel.vb](./VB/Q521663/ViewModel.vb))

## Documentation

* [WPF Ribbon, Bars, and Menu: MVVM Support](https://docs.devexpress.com/WPF/10434/controls-and-libraries/ribbon-bars-and-menu/common-concepts/mvvm-support)
* [Ribbon Structure ](https://docs.devexpress.com/WPF/7954/controls-and-libraries/ribbon-bars-and-menu/ribbon/ribbon-structure/ribbon-control)

## More Examples

* [Create a WPF RibbonControl](https://github.com/DevExpress-Examples/wpf-create-a-ribboncontrol)
* [WPF Bars - Generate Bar Items from a View Model Collection in an MVVM Application](https://github.com/DevExpress-Examples/wpf-bars-mvvm-generate-bars-from-view-model-collection)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-ribbon-generate-pages-groups-and-items-from-viewmodel-collection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-ribbon-generate-pages-groups-and-items-from-viewmodel-collection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
