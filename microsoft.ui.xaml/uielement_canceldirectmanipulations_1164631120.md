---
-api-id: M:Microsoft.UI.Xaml.UIElement.CancelDirectManipulations
-api-type: winrt method
---

<!-- Method syntax
public bool CancelDirectManipulations()
-->

# Microsoft.UI.Xaml.UIElement.CancelDirectManipulations

## -description
Cancels ongoing direct manipulation processing (system-defined panning/zooming) on any [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) parent that contains the current [UIElement](uielement.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
**true** if a [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) parent exists and setting the value resulted in canceling the panning/zooming action. **false** if calling the method results in no action.

## -remarks
You might call this method if you want the target [UIElement](uielement.md) to be able to process ongoing manipulations through the lower-level pointer events ([PointerPressed](uielement_pointerpressed.md), [PointerMoved](uielement_pointermoved.md) and so on). By default, if the target [UIElement](uielement.md) is contained in a [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md), that [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) parent would handle translation manipulations directly at the system level, treating them as pan or zoom. Manipulation handling by the [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) parent prevents the contained [UIElement](uielement.md) from receiving the pointer events (they would be marked as handled). Call CancelDirectManipulations to override this default behavior for an ongoing manipulation, and then you'll be able to handle manipulations at a non-system level for the individual [UIElement](uielement.md) target.

## -examples

## -see-also
[ManipulationMode](uielement_manipulationmode.md), [Gestures, manipulations, and interactions](/previous-versions/windows/apps/hh761498(v=win.10))
