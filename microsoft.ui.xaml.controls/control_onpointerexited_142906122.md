---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.OnPointerExited(Microsoft.UI.Xaml.Input.PointerRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnPointerExited(Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
-->

# Microsoft.UI.Xaml.Controls.Control.OnPointerExited

## -description
Called before the [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) event occurs.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param e
Event data for the event.

## -remarks
<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 465675-->
### Windows 8 behavior

For Windows 8, generally the [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) event won't fire if the onscreen cursor (or stylus or touchpoint) did not actually move. For example, [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) doesn't fire if the mouse and its onscreen cursor remains stationary, and an object with a [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) handler has its position translated or otherwise adjusted to move underneath the onscreen cursor. Or, [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) doesn't fire if an element like a popup or flyout disappears and the pointer is now over a new element (but pointer hasn't moved yet). Related to this is the [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) behavior. For example, if a popup is dismissed programmatically, it won't fire [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) if the pointer didn't move as the cause of dismissing it. You would still get a [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) event if the pointer moves while over the newly revealed element, but that's up to the user whether that will happen, and it happens at the time of movement, not the moment of dismissal. In short, trying to use the last element that fired [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) for pointer state determination in the app UI isn't comprehensive in Windows 8, and there are many scenarios where [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) and [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) won't pair up. This impacts the visual states for controls that use [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) and [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) as triggers also.

Starting with Windows 8.1, [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) is fired for any case where the pointer had at one time fired a [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) event, but some UI state change happens where the pointer is no longer within that element. This includes cases where the whole element disappears. And if the pointer is now over a different element because a previous element disappeared, that element fires [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md), even if the pointer never moves. Elements that set their [Visibility](../microsoft.ui.xaml/uielement_visibility.md) to **Collapsed** programmatically is one way that elements might disappear from UI, and the Windows 8.1 behavior accounts for this and will fire [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) for the **Collapsed ** element and [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) for the newly revealed element.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) and [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) being fired in cases where they wouldn't have fired before.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[UIElement.PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md), [PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/apps/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
