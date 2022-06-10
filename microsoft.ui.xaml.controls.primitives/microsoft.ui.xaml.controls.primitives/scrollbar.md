---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.ScrollBar
-api-type: winrt class
---

<!-- Class syntax.
public class ScrollBar : Windows.UI.Xaml.Controls.Primitives.RangeBase, Windows.UI.Xaml.Controls.Primitives.IScrollBar
-->

# Microsoft.UI.Xaml.Controls.Primitives.ScrollBar

## -description

Represents a control that provides a scroll bar that has a sliding [Thumb](thumb.md) whose position corresponds to a value.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<ScrollBar .../>
```

## -remarks

If you need to handle pointer events for a [UIElement](../microsoft.ui.xaml/uielement.md) in a scrollable view (such as a ScrollViewer), you must explicitly disable support for manipulation events on the element in the view by calling [UIElement.CancelDirectmanipulation()](../microsoft.ui.xaml/uielement_canceldirectmanipulations_1164631120.md). To re-enable manipulation events in the view, call [UIElement.TryStartDirectManipulation()](/uwp/api/windows.ui.xaml.uielement.trystartdirectmanipulation(windows.ui.xaml.input.pointer)).

## -examples

## -see-also

[RangeBase](rangebase.md)
