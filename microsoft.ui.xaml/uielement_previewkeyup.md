---
-api-id: E:Microsoft.UI.Xaml.UIElement.PreviewKeyUp
-api-type: winrt event
---

<!-- Event syntax.
public event KeyEventHandler PreviewKeyUp
-->

# Microsoft.UI.Xaml.UIElement.PreviewKeyUp

## -description

Occurs when a keyboard key is released while the [UIElement](uielement.md) has focus.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<uiElement PreviewKeyUp="eventhandler"/>
```

## -remarks

[PreviewKeyDown](uielement_previewkeydown.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

This event uses the tunneling routing strategy. The corresponding bubbling event is [KeyUp](uielement_keyup.md).

## -see-also

[KeyRoutedEventArgs](../microsoft.ui.xaml.input/keyroutedeventargs.md), [KeyUp](uielement_keyup.md)

## -examples
