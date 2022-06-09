---
-api-id: P:Microsoft.UI.Xaml.BringIntoViewOptions.VerticalAlignmentRatio
-api-type: winrt property
---

<!-- Property syntax.
public double VerticalAlignmentRatio { get;  set; }
-->

# Microsoft.UI.Xaml.BringIntoViewOptions.VerticalAlignmentRatio

## -description
Controls the positioning of the horizontal axis of the TargetRect with respect to the horizontal axis of the viewport. The value is clamped from 0.0f to 1.0f with 0.0f representing the top horizontal edge and 1.0f representing the bottom horizontal edge. By default this is set to 0.0f.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

A value that specifies the positioning of the horizontal axis of the TargetRect with respect to the horizontal axis of the viewport. The default is 0.0f.

## -remarks
A value of 0.0f indicates the TargetRect should be top-aligned in the viewport. A value of 1.0f indicates it should be bottom-aligned. A value of 0.5 indicates the TargetRect is vertically centered in the viewport.

## -see-also

## -examples

