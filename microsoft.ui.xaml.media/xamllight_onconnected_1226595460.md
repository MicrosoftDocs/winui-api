---
-api-id: M:Microsoft.UI.Xaml.Media.XamlLight.OnConnected(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
virtual protected void XamlLight.OnConnected(UIElement newElement)
-->

# Microsoft.UI.Xaml.Media.XamlLight.OnConnected


## -description

This method is automatically called when the XamlLight is first in use on the screen, or after being previously disconnected then used again.

This provides an opportunity to create resources such as the CompositionLight only when required.

[OnDisconnected](xamllight_ondisconnected_1949383343.md) will be called when the XamlLight is no longer being used to light any UIElements or Brushes.

## -parameters

### -param newElement

The [UIElement](/uwp/api/Windows.UI.Xaml.UIElement) that the light is attached to.

## -remarks

## -see-also

## -examples

