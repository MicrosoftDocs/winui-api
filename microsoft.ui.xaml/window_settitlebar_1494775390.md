---
-api-id: M:Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)

<!--
public void SetTitleBar (Microsoft.UI.Xaml.UIElement titleBar);
-->


## -description
Makes a XAML element interact with the system as if it’s the title bar.


## -parameters

### -param titleBar

## -remarks
When this method is used, a user can move the window by dragging the XAML UIElement, or a user can invoke the window context menu by right-clicking it. As a consequence the app no longer
receives pointer input when the user interacts with the target UIElement or its children using touch, mouse, or pen. 
The UIElement does still receive keyboard input.

Only one UIElement can act as Title bar, so the last set wins. To use multiple objects, 
you need to wrap them in a container element (for example a Grid).

The rectangular area occupied by the element acts as the title bar for pointer purposes,
even if the element is blocked by another element,
and even if the element is transparent.

This method is typically used with the Window's [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) property 
set to true in order to hide the default system title bar.
However, even when the default system title bar is not hidden, SetTitleBar can be used to make 
additional regions in your app behave like the title bar.

Title bars should have background and foreground colors based on
whether the window is current foreground (active) or background. Additionally, there's an 
option in Windows Settings to use the user's accent color as the foreground of the title bar.

## -see-also
- [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) 

## -examples

The following shows a Window with a no built-in title bar. 
Instead it uses the whole window as its content area. To enable features such as window dragging, 
it designates a TextBlock as the title bar.

```xml
<Window ...>
    <Grid>
        <!-- ... -->

        <TextBlock x:Name="CustomTitleBar">Custom title text</TextBlock>

        <!-- ... -->
    </Grid>

</Window>
```

```CS
private Window m_window;

protected override void OnLaunched(Microsoft.UI.Xaml.XamlLaunchActivatedEventArgs args)
{
    m_window = new MainWindow();

    m_window.ExtendContentIntoTitleBar = true;
    m_window.SetTitleBar(m_window.CustomTitleBar);

    m_window.Activate();
}
```
