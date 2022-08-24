---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.LayoutInformation.GetAvailableSize(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public Size LayoutInformation.GetAvailableSize(UIElement element)
-->

# Microsoft.UI.Xaml.Controls.Primitives.LayoutInformation.GetAvailableSize

## -description

Returns the Size value that was most recently used to measure the specified element.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param element

The element for which to return the most recent size.

## -returns

The Size given as an argument on the most recent call to measure this element, or a Size of 0,0 if the element has not been measured yet.

## -remarks

## -see-also

[UIElement.Measure](../microsoft.ui.xaml/uielement_measure_1722732750.md)

## -examples

