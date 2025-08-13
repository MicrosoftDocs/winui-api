---
-api-id: E:Microsoft.UI.Xaml.Controls.TabView.TabDroppedOutside
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TabView.TabDroppedOutside

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TabView,Microsoft.UI.Xaml.Controls.TabViewTabDroppedOutsideEventArgs> TabDroppedOutside;
-->

## -description

Occurs when the user completes a drag and drop operation by dropping a tab outside of the TabStrip area.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

You can use this event to create a new window.

There are different ways that content can be hosted inside an app. The [Show multiple views for an app](/windows/uwp/ui-input/show-multiple-views) documentation outlines the various technologies for displaying multiple views or windows.

The example below uses AppWindow, which is available starting in Windows 10, version 1903 (SDK 18362). AppWindow simplifies the creation of multi-window UWP apps because it operates on the same UI thread that it's created from.

If your app targets Windows 10 versions less than 1903, you will need to use CoreWindow/ApplicationView. The Windows Community Toolkit [TabView tear out sample](https://github.com/windows-toolkit/Sample-TabView-TearOff/tree/master/TabViewTear) demonstrates how to create a multi-window application using CoreWindow/ApplicationView.

## -see-also

[CanDragTabs](tabview_candragtabs.md), [CanReorderTabs](tabview_canreordertabs.md), [AllowDropTabs](tabview_allowdroptabs.md), [TabDragStarting](tabview_tabdragstarting.md), [TabStripDragOver](tabview_tabstripdragover.md), [TabStripDrop](tabview_tabstripdrop.md), [TabDragCompleted](tabview_tabdragcompleted.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Tab view](/windows/apps/design/controls/tab-view).
>
> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality.
>
> If installed already, open it by clicking [**WinUI 2 Gallery**](winui2gallery:/item/TabView).
>
> If they are not installed, you can download the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *winui2* branch for WinUI 2).

This example shows how to create a new window for a tab that is dragged out of the tab strip.

``` xaml
<TabView TabDroppedOutside="TabView_TabDroppedOutside">
```

``` csharp
// NOTE: You need to write this code in your app. A full sample can be found in the WinUI 2 Controls Gallery.
private async void TabView_TabDroppedOutside(TabView sender, TabDroppedOutsideEventArgs e)
{
    // Create a new AppWindow
    AppWindow newWindow = await AppWindow.TryCreateAsync();

    // Create the content for the new window
    var newPage = new MainPage();

    // Remove tab from existing list
    Tabs.TabItems.Remove(e.Tab);

    // Add tab to list of Tabs on new page
    newPage.AddItemToTabs(e.Tab);

    // Set the Window's content to the new page
    ElementCompositionPreview.SetAppWindowContent(newWindow, newPage);

    // Show the window
    await newWindow.TryShowAsync();
}
```
