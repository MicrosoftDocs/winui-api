---
-api-id: P:Microsoft.UI.Xaml.BringIntoViewRequestedEventArgs.HorizontalOffset
-api-type: winrt property
---

<!-- Property syntax.
public double HorizontalOffset { get;  set; }
-->

# Microsoft.UI.Xaml.BringIntoViewRequestedEventArgs.HorizontalOffset

## -description
Gets or sets the horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested [HorizontalAlignmentRatio](bringintoviewrequestedeventargs_horizontalalignmentratio.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested [HorizontalAlignmentRatio](bringintoviewrequestedeventargs_horizontalalignmentratio.md).

## -remarks
This value can be modified by event handlers as the event bubbles. A scrolling control that partially or fully satisfies the request will adjust the requested HorizontalOffset to reflect the remaining amount that it could not satisfy.

## -see-also

## -examples

