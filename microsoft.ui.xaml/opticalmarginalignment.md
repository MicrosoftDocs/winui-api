---
-api-id: T:Microsoft.UI.Xaml.OpticalMarginAlignment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.OpticalMarginAlignment : int
-->

# OpticalMarginAlignment

## -description
Specifies how side bearing values in per-character typography are handled when aligning to a text container boundary.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field None:0
Use side bearings that come from font typography values. This is the default.

### -field TrimSideBearings:1
Don't use side bearings that come from font typography values, and align the side of the glyph to where the "ink" part of the glyph begins.


## -remarks
This enumeration is used as a value by [TextBlock.OpticalMarginAlignment](../microsoft.ui.xaml.controls/textblock_opticalmarginalignment.md) and [RichTextBlock.OpticalMarginAlignment](../microsoft.ui.xaml.controls/richtextblock_opticalmarginalignment.md).

When fonts of different sizes are aligned vertically in the same or nearby containers, the advance width and side bearing of the characters can cause the alignment to appear ragged. This can be prevented by setting a property that uses OpticalMarginAlignment to use the **TrimSideBearings** constant.

## -examples

## -see-also
[TextBlock.OpticalMarginAlignment](../microsoft.ui.xaml.controls/textblock_opticalmarginalignment.md), [RichTextBlock.OpticalMarginAlignment](../microsoft.ui.xaml.controls/richtextblock_opticalmarginalignment.md)
