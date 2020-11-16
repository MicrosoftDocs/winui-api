---
-api-id: M:Microsoft.UI.Xaml.Input.RightTappedRoutedEventArgs.GetPosition(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Point GetPosition(Windows.UI.Xaml.UIElement relativeTo)
-->

# Microsoft.UI.Xaml.Input.RightTappedRoutedEventArgs.GetPosition

## -description
Returns the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin of a supplied [UIElement](../microsoft.ui.xaml/uielement.md).

## -parameters
### -param relativeTo
Any [UIElement](../microsoft.ui.xaml/uielement.md)-derived object that is connected to the same object tree. To specify the object relative to the overall coordinate system, use a *relativeTo*  value of **null**.

## -returns
A [Point](/uwp/api/windows.foundation.point) that represents the current x- and y-coordinates of the mouse pointer position. If **null** was passed as *relativeTo*, this coordinate is for the overall window. If a *relativeTo* value other than **null** was passed, this coordinate is relative to the object referenced by *relativeTo*.

## -remarks
<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 458128-->
### Windows 8 behavior

Windows 8 had an issue with the data for the [RightTapped](../microsoft.ui.xaml/uielement_righttapped.md) event, where the **X** and **Y** values for the point you'd get from RightTappedRoutedEventArgs.GetPosition were reversed (**X** was really **Y**; **Y** was really **X**). This issue has been fixed starting with Windows 8.1. But if you're retargeting a Windows 8 app for Windows 8.1, you might have had code that worked around this issue by swapping the **X** and **Y** back. If so, remove that code when you retarget because the issue is now fixed.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[Point](/uwp/api/windows.foundation.point), [RightTapped](../microsoft.ui.xaml/uielement_righttapped.md), [OnRightTapped](/uwp/api/windows.ui.xaml.controls.control.onrighttapped(windows.ui.xaml.input.righttappedroutedeventargs)), [HoldingRoutedEventArgs](holdingroutedeventargs.md)
