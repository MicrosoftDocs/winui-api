---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs.IsInertial
-api-type: winrt property
---

<!-- Property syntax
public bool IsInertial { get; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs.IsInertial

## -description
Gets a value that indicates whether the pan/zoom manipulation has an inertial component.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
**true** if the pan/zoom manipulation has an inertial component; otherwise, **false**.

## -remarks

IsInertial is **true** for manipulations that occur:

+ using a mouse wheel.
+ using key strokes on [ScrollViewer](scrollviewer.md) and other controls that support direct manipulation.
+ by calling [ChangeView](scrollviewer_changeview_579623452.md) with animation enabled.

IsInertial is **false** for manipulations that occur:

+ by dragging the [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) on a scrollbar.
+ using key strokes on controls that don't support direct manipulation.
+ by calling [ChangeView](scrollviewer_changeview_579623452.md) with animation disabled.


## -examples

## -see-also
