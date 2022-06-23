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
