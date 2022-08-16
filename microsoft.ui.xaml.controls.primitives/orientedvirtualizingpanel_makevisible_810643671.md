---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.MakeVisible(Microsoft.UI.Xaml.UIElement,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Rect MakeVisible(Windows.UI.Xaml.UIElement visual, Windows.Foundation.Rect rectangle)
-->

# Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.MakeVisible

## -description
Changes existing offsets in order to make the provided element visible in the viewport, and returns a [Rect](/uwp/api/windows.foundation.rect) measurement of the area.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param visual
The element to make visible.

### -param rectangle
A rectangle representing the element's coordinate space.

## -returns
A rectangle representing the input *rectangle*[Rect](/uwp/api/windows.foundation.rect) transformed using the [OrientedVirtualizingPanel](orientedvirtualizingpanel.md) coordinate space after scrolling happens. 
<!--The code makes it look like it is a shell. Test.-->

## -remarks

## -examples

## -see-also
