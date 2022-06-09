---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.OnKeyUp(Microsoft.UI.Xaml.Input.KeyRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnKeyUp(Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
-->

# Microsoft.UI.Xaml.Controls.Control.OnKeyUp

## -description
Called before the [KeyUp](../microsoft.ui.xaml/uielement_keyup.md) event occurs.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param e
The data for the event.

## -remarks
As it's implemented directly on [Control](control.md), OnKeyUp has an empty implementation. But each ancestor in a control's hierarchy may have provided an implementation. You won't be able to see this implementation because it's internal native code. In some cases a control will already have existing **On**_Event_ overrides that mark the event **Handled**. For key events, controls are usually only handling for certain keys, by checking values in [KeyRoutedEventArgs](../microsoft.ui.xaml.input/keyroutedeventargs.md). For example, [ButtonBase](../microsoft.ui.xaml.controls.primitives/buttonbase.md) detects the Space key as a way to fire [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md). Control code or your code probably shouldn't be suppressing all key events, because it's a common pattern to let key events bubble to the root visual so that they can be shortcuts or accelerators for app interaction. For more info see [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions).

## -examples

## -see-also
[UIElement.KeyUp](../microsoft.ui.xaml/uielement_keyup.md), [KeyRoutedEventArgs](../microsoft.ui.xaml.input/keyroutedeventargs.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)
