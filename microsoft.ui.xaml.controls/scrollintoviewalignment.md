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
