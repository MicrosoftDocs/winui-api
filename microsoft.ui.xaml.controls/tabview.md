---
-api-id: T:Microsoft.UI.Xaml.Controls.TabView
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.TabView

<!--
public class TabView : Windows.UI.Xaml.Controls.Control
-->

## -description

The TabView control is a way to display a set of tabs and their respective content. Tab controls are useful for displaying several pages (or documents) of content while giving a user the capability to rearrange, open, or close new tabs.

**Is this the right control?**

Use a TabView to help the user manage multiple app pages or documents within the same window.

Do not use a TabView to display a static set of tabs that the user cannot rearrange, open, or close. Use a [NavigationView](navigationview.md) ([NavigationViewPaneDisplayMode](navigationviewpanedisplaymode.md) of Top) instead.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](/uwp/api/windows.ui.xaml.controls.control.background) and [Foreground](/uwp/api/windows.ui.xaml.controls.control.foreground). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [TabView_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/TabView/TabView_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[TabViewItem](tabviewitem.md), [TabViewCloseButtonOverlayMode](tabviewclosebuttonoverlaymode.md), [Guidelines for TabView](/windows/apps/design/controls/tab-view)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Tab view](/windows/apps/design/controls/tab-view).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see TabView in action](winui2gallery:/item/TabView).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).


### Basic TabView Sample, similar to a Web Browser

``` xml
<TabView AddTabButtonClick="Tabs_AddTabButtonClick"
         TabCloseRequested="Tabs_TabCloseRequested" />
```

``` csharp
// Add a new Tab to the TabView
private void Tabs_AddTabButtonClick(TabView sender, TabViewAddTabButtonClickEventArgs e)
{
    var newTab = new TabViewItem();
    newTab.IconSource = new SymbolIconSource() { Symbol = Symbol.Document };
    newTab.Header = "New Document";

    // The Content of a TabViewItem is often a frame which hosts a page.
    Frame frame = new Frame();
    newTab.Content = frame;
    frame.Navigate(typeof(BaconIpsumPage));

    sender.TabItems.Add(newTab);
}

// Remove the requested tab from the TabView
private void Tabs_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
{
    sender.TabItems.Remove(args.Tab);
}
```
