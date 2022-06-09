---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.RecycleElement(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.RecycleElement(Windows.UI.Xaml.UIElement)

<!--
public void RecycleElement (Windows.UI.Xaml.UIElement element);
-->

## -description

Clears the specified UIElement and allows it to be either re-used or released.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param element

The element to clear.

## -remarks

This method calls [RecycleElementCore(Windows.UI.Xaml.UIElement)](virtualizinglayoutcontext_recycleelementcore_841643362.md), which must be implemented in a derived class.

## -see-also

## -examples
