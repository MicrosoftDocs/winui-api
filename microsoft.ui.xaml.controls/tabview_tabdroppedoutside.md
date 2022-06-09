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

There are different ways that content can be hosted inside an app. The [Show multiple views for an app](https://docs.microsoft.com/windows/apps/design/layout/show-multiple-views) documentation outlines the various technologies for displaying multiple views or windows. 

The example below uses AppWindow, which is available starting in Windows 10, version 1903 (SDK 18362). AppWindow simplifies the creation of multi-window UWP apps because it operates on the same UI thread that it's created from.

If your app targets Windows 10 versions less than 1903, you will need to use CoreWindow/ApplicationView. The Windows Community Toolkit [TabView tear out sample](https://github.com/windows-toolkit/Sample-TabView-TearOff/tree/master/TabViewTear) demonstrates how to create a multi-window application using CoreWindow/ApplicationView.

## -see-also

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [TabView](/windows/apps/design/controls/tab-view).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/TabView) or [**WinUI 2 Gallery**](winui2gallery:/item/TabView).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


``` xml
<TabView TabDroppedOutside="TabView_TabDroppedOutside">
```

``` csharp
// NOTE: The app is responsible for writing this code. A full sample can be found in the Xaml Controls Gallery.
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

