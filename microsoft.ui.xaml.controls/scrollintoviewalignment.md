---
-api-id: T:Microsoft.UI.Xaml.Controls.ScrollIntoViewAlignment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.ScrollIntoViewAlignment : int
-->

# ScrollIntoViewAlignment

## -description
Defines constants that describe how an item that is programmatically scrolled into view aligns with the visible area.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field Default:0
The item aligns with the nearest edge.

### -field Leading:1
The item aligns with the leading edge.


## -remarks
When scrolled vertically, the leading edge is the top edge.

When scrolled horizontally, the leading edge is the left edge if [FlowDirection](../microsoft.ui.xaml/frameworkelement_flowdirection.md) is [LeftToRight](../microsoft.ui.xaml/flowdirection.md), and the right edge if [FlowDirection](../microsoft.ui.xaml/frameworkelement_flowdirection.md) is [RightToLeft](../microsoft.ui.xaml/flowdirection.md).

## -examples

## -see-also
[ListViewBase.ScrollIntoView](/uwp/api/windows.ui.xaml.controls.listviewbase.scrollintoview)
