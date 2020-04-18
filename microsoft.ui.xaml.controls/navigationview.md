---
-api-id: T:Microsoft.UI.Xaml.Controls.NavigationView
-api-type: winrt class
ms.custom: RS5
---
<!-- Class syntax.
public class NavigationView : ContentControl, ContentControl
-->

# Microsoft.UI.Xaml.Controls.NavigationView


## -description

Represents a container that enables navigation of app content. It has a header, a view for the main content, and a menu pane for navigation commands.


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

## -see-also

[Guidelines for navigation view](/windows/uwp/controls-and-patterns/navigationview), [Back button in NavigationView](/windows/uwp/design/basics/navigation-history-and-backwards-navigation)

## -examples


## -xaml-syntax

```xaml
<NavigationView .../>
```


