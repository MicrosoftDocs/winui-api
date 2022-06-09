---
-api-id: M:Microsoft.UI.Xaml.Media.XamlCompositionBrushBase.OnDisconnected
-api-type: winrt method
---

<!-- Method syntax.
virtual protected void XamlCompositionBrushBase.OnDisconnected()
-->

# Microsoft.UI.Xaml.Media.XamlCompositionBrushBase.OnDisconnected

## -description
Invoked when the brush is no longer being used to paint any elements. 

When implemented in a derived class, you can safely dispose of the compostion brush and other composition resources.

[OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) will be called again if the brush is later used to paint any elements after being disconnected.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

## -see-also

## -examples

