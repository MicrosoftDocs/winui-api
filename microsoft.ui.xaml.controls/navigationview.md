---
-api-id: T:Microsoft.UI.Xaml.Controls.NavigationView
-api-type: winrt class
---
<!-- Class syntax.
public class NavigationView : ContentControl, ContentControl
-->

# Microsoft.UI.Xaml.Controls.NavigationView

## -description

Represents a container that enables navigation of app content. It has a header, a view for the main content, and a menu pane for navigation commands.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

### Access keys for built-in elements

To add access keys for the _back arrow_ and _settings_ buttons that are built-in to NavigationView, you have to use [VisualTreeHelper](/uwp/api/windows.ui.xaml.media.visualtreehelper) to get a reference to those controls, then set the properties in your code.

This example shows how to handle the [Loaded](/uwp/api/windows.ui.xaml.frameworkelement.loaded) event to find the elements in the visual tree and set the [AccessKey](/uwp/api/windows.ui.xaml.uielement.accesskey) and [KeyTipPlacementMode](/uwp/api/windows.ui.xaml.uielement.keytipplacementmode) properties.

```csharp
private void NavigationView_Loaded(object sender, RoutedEventArgs e)
{
    // using muxc = Microsoft.UI.Xaml.Controls;

    var navView = sender as muxc.NavigationView;
    var rootGrid = VisualTreeHelper.GetChild(navView, 0) as Grid;

    // Find the back button.
    var paneToggleButtonGrid = VisualTreeHelper.GetChild(rootGrid, 0) as Grid;
    var buttonHolderGrid = VisualTreeHelper.GetChild(paneToggleButtonGrid, 1) as Grid;
    var navigationViewBackButton = VisualTreeHelper.GetChild(buttonHolderGrid, 0) as Button;

    navigationViewBackButton.AccessKey = "A";

    if (navView.PaneDisplayMode == muxc.NavigationViewPaneDisplayMode.Top)
    {
        // Set back button key tip placement mode.
        navigationViewBackButton.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Bottom;

        // Find the settings item and set properties.
        var grid = VisualTreeHelper.GetChild(rootGrid, 1) as Grid;
        var topNavArea = VisualTreeHelper.GetChild(grid, 0) as StackPanel;
        var topNavGrid = VisualTreeHelper.GetChild(topNavArea, 1) as Grid;
        var settingsTopNavPaneItem = VisualTreeHelper.GetChild(topNavGrid, 8) as muxc.NavigationViewItem;

        settingsTopNavPaneItem.AccessKey = "S";
        settingsTopNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Bottom;
    }
    else
    {
        // Set back button key tip placement mode.
        navigationViewBackButton.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;

        // Find the settings item and set properties.
        var grid = VisualTreeHelper.GetChild(rootGrid, 1) as Grid;
        var rootSplitView = VisualTreeHelper.GetChild(grid, 1) as SplitView;
        var grid2 = VisualTreeHelper.GetChild(rootSplitView, 0) as Grid;
        var paneRoot = VisualTreeHelper.GetChild(grid2, 0) as Grid;
        var border = VisualTreeHelper.GetChild(paneRoot, 0) as Border;
        var paneContentGrid = VisualTreeHelper.GetChild(border, 0) as Grid;
        var settingsNavPaneItem = VisualTreeHelper.GetChild(paneContentGrid, 6) as muxc.NavigationViewItem;

        settingsNavPaneItem.AccessKey = "S";
        settingsNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;
    }
}
```

### Specific keyboarding guidelines

NavigationView supports hierarchy and nested items, which slightly changes the expected keyboarding behavior. For more information on keyboarding within a hierarchical NavigationView, see the [hierarchical NavigationView guidelines documentation](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/navigationview#hierarchical-navigation).

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](/uwp/api/windows.ui.xaml.controls.control.background) and [Foreground](/uwp/api/windows.ui.xaml.controls.control.foreground). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [NavigationView_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/NavigationView/NavigationView_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[Guidelines for navigation view](/windows/uwp/controls-and-patterns/navigationview), [Back button in NavigationView](/windows/apps/design/basics/navigation-history-and-backwards-navigation)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Navigation view](/windows/apps/design/controls/navigationview).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the NavigationView in action](winui2gallery:/item/NavigationView).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -xaml-syntax

```xaml
<NavigationView .../>
```
