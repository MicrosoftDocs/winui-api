---
-api-id: M:Microsoft.UI.Xaml.Media.XamlLight.OnDisconnected(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
virtual protected void XamlLight.OnDisconnected(UIElement oldElement)
-->

# Microsoft.UI.Xaml.Media.XamlLight.OnDisconnected


## -description

This method is automatically called when the XamlLight is no longer in use anywhere on the screen.

This provides an opportunity to safely dispose of resources such as the CompositionLight when they aren't currently required.

[OnConnected](xamllight_onconnected_1226595460.md) will be called again if the XamlLight is later used to light any UIElements or Brushes after being disconnected.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param oldElement

The [UIElement](/uwp/api/Windows.UI.Xaml.UIElement) that the light is attached to.

## -remarks

## -see-also

## -examples

