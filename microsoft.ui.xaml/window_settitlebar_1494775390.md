---
-api-id: M:Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)

<!--
public void SetTitleBar (Microsoft.UI.Xaml.UIElement titleBar);
-->

## -description

Enables title bar behavior on a XAML element.

## -parameters

### -param titleBar

The element to support title bar behavior.

## -remarks

The following two steps are required when specifying a custom window title bar:

1. Set [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) to true to hide the Windows default title bar and allocate space for a custom title bar.
2. Call this method and pass in your [UIElement](uielement.md).

If you skip step 1, the default title bar is not hidden and your custom title bar is not shown.
If you skip step 2, a small area next to the min/max/close buttons is allocated for the custom title bar until [SetTitleBar](window_settitlebar_1494775390.md) is called with a valid UIElement.

Only a single element can be specified. If multiple elements are required, they can be specified as child elements of a single container (such as a [Grid](../microsoft.ui.xaml.controls/grid.md) or [StackPanel](../microsoft.ui.xaml.controls/stackpanel.md)). If multiple elements are specified instead of a container, the last element specified is used.

The custom title bar works best when it is the top-most child of the parent container of your app. Deep nesting the [UIElement](uielement.md) within the XAML tree might cause unpredictable layout behaviors.

For example:

```xaml
<StackPanel>

  <StackPanel name="customtitlebar">

  <... rest of XAML ...>

</StackPanel>
```

Don’t set the background property on a [UIElement](uielement.md) being used as a custom title bar. The min/max/close buttons will be hidden as the background color gets drawn over them. 

In order to customize the colors of the custom title bar, you can modify the following corresponding resources (shown here with their default values):

```xaml
<StaticResource x:Key="WindowCaptionBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
<StaticResource x:Key="WindowCaptionBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
<StaticResource x:Key="WindowCaptionForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
<StaticResource x:Key="WindowCaptionForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
```

The following snippet shows how to override the default values in application.xaml.

```xaml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls" />
            <!-- Other merged dictionaries here -->
        </ResourceDictionary.MergedDictionaries>
        <!-- Other app resources here -->
        <SolidColorBrush x:Key="WindowCaptionBackground">Green</SolidColorBrush>
        <SolidColorBrush x:Key="WindowCaptionBackgroundDisabled">LightGreen</SolidColorBrush>
        <SolidColorBrush x:Key="WindowCaptionForeground">Red</SolidColorBrush>
        <SolidColorBrush x:Key="WindowCaptionForegroundDisabled">Pink</SolidColorBrush>
    </ResourceDictionary>
</Application.Resources>
```

The specified element supports the same system interactions as the standard title bar, including drag, double-click resize, and right-click window context menu. As a result, pointer input (mouse, touch, pen, and so on) is no longer recognized by the element and its child elements.

The rectangular area occupied by the specified element acts as the title bar for pointer purposes, even if the element is blocked by another element, or the element is transparent.

Keyboard input is recognized by the specified element.

Title bars should have foreground and background colors based on whether the window is currently active (in the foreground) or not. Users can also specify their own accent color to use for title bars (**Settings -> Personalization -> Colors -> Choose your accent color**).

## -examples

The following shows how to override the system title bar and extend the window's content area. To provide title bar features, a TextBlock is designated as the title bar.

```xaml
<Window ...>
    <Grid>
        <!-- ... -->

        <TextBlock x:Name="CustomTitleBar">Custom title text</TextBlock>

        <!-- ... -->
    </Grid>
</Window>
```

```CS
private MainWindow m_window;

protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
{
    m_window = new MainWindow();

    m_window.ExtendsContentIntoTitleBar = true;
    m_window.SetTitleBar(m_window.CustomTitleBar);

    m_window.Activate();
}
```

## -see-also

[ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md), [IWindowNative](/windows/apps/winui/reference/iwindownative)
