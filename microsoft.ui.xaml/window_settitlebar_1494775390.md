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

Only a single element can be specified. If multiple elements are required, they can be specified as child elements of a single container (such as a [Grid](../microsoft.ui.xaml.controls/grid.md) or [StackPanel](../microsoft.ui.xaml.controls/stackpanel.md)). If multiple elements are specified instead of a container, the last element specified is used.

The specified element supports the same system interactions as the standard title bar, including drag, double-click resize, and right-click window context menu. As a result, pointer input (mouse, touch, pen, and so on) is no longer recognized by the element and its child elements.

The rectangular area occupied by the specified element acts as the title bar for pointer purposes, even if the element is blocked by another element, or the element is transparent.

Keyboard input is recognized by the specified element.

This method is typically used when the [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) property of the window is set to true (in order to hide the default system title bar). However, even when the default system title bar is not hidden, this method can still be used to make additional regions in your application behave like the title bar.

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

protected override void OnLaunched(Microsoft.UI.Xaml.XamlLaunchActivatedEventArgs args)
{
    m_window = new MainWindow();

    m_window.ExtendsContentIntoTitleBar = true;
    m_window.SetTitleBar(m_window.CustomTitleBar);

    m_window.Activate();
}
```

## -see-also

[ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md), [IWindowNative](/windows/apps/winui/reference/iwindownative)
