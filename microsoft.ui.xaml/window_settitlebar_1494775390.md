---
-api-id: M:Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)

<!--
public void SetTitleBar (Microsoft.UI.Xaml.UIElement titleBar);
-->

## -description

Enables title bar behavior on a XAML element when `ExtendsContentIntoTitleBar` is `true`.

## -parameters

### -param titleBar

The element to support title bar behavior.

## -remarks

Call this method to replace the system title bar with a custom title bar UI for your app. The specified element supports the same system interactions as the system title bar, including drag, double-click to resize, and right-click to show the system menu. As a result, pointer input (mouse, touch, pen, and so on) is no longer recognized by the element and its child elements.

The rectangular area occupied by the specified element acts as the title bar for pointer purposes, even if the element is blocked by another element, or the element is transparent.

## Extend content into title bar

To specify a custom title bar, you must set [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) to `true` to hide the default system title bar. If `ExtendsContentIntoTitleBar` is `false`, the call to `SetTitleBar` does not have any effect. Your custom title bar element is shown in the body of your app window as an ordinary UI element and does not get the title bar behaviors.

If you set [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) to `true` but do not call `SetTitleBar`, the system title bar is restricted to the caption buttons and a small area next to the caption buttons that is reserved for title bar behaviors. However, your custom title bar element does not get title bar behaviors, such as drag and the system menu, until [SetTitleBar](window_settitlebar_1494775390.md) is called with a valid [UIElement](uielement.md).

## Title bar element

Only a single element can be specified as the title bar. If multiple elements are required, they can be specified as child elements of a single container (such as a [Grid](../microsoft.ui.xaml.controls/grid.md) or [StackPanel](../microsoft.ui.xaml.controls/stackpanel.md)). If multiple elements are specified instead of a container, the last element specified is used.

The title bar element is presented over the caption buttons, so you should set the side margins of your UIElement to leave space for the caption buttons. (If the title bar element has a transparent background, the caption buttons will show through but will not receive any input.) For example, if all caption buttons (minimize, maximize/restore, and close) are shown on the right side of the window, your title bar element should have a right margin value of 120 to ensure enough space for the buttons.

The custom title bar works best when it is the top-most child of the parent container of your app. Deep nesting the [UIElement](uielement.md) within the XAML tree might cause unpredictable layout behaviors.

For example:

```xaml
<!-- NOT RECOMMENDED -->
<Grid x:Name="RootGrid">
    <StackPanel>
        <StackPanel x:Name="CustomTitleBar">
        <... more XAML ...>
    </StackPanel>
    <... more XAML ...>
</Grid>
```

## Colors

When you use a custom title bar, you can modify the colors of the caption buttons to match your app. To do so, override the following resources (shown here with their default values):

```xaml
<StaticResource x:Key="WindowCaptionBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
<StaticResource x:Key="WindowCaptionBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
<StaticResource x:Key="WindowCaptionForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
<StaticResource x:Key="WindowCaptionForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
```

This example shows how to override the default values in App.xaml.

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

## -examples

This example shows how to extend the window's content area and replace the system title bar with a Grid that contains an icon and title text.

```xaml
<Grid x:Name="AppTitleBar" Margin="0,0,120,0">
    <Image Source="Assets/Square44x44Logo.png"
           HorizontalAlignment="Left" 
           Width="20" Height="20" Margin="12,0"/>
    <TextBlock x:Name="AppTitleTextBlock" Text="Custom Title Bar" 
               Style="{StaticResource CaptionTextBlockStyle}" 
               Margin="44,0,0,0" VerticalAlignment="Center"/>
</Grid>
```

```csharp
public MainWindow()
{
    this.InitializeComponent();

    ExtendsContentIntoTitleBar = true;
    SetTitleBar(AppTitleBar);
}
```

## -see-also

[ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md), [IWindowNative](/windows/apps/winui/reference/iwindownative)
