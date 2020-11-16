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

## -xaml-syntax

```xaml
<ScrollBar .../>
```

## -remarks

If you need to handle pointer events for a [UIElement](../microsoft.ui.xaml/uielement.md) in a scrollable view (such as a ScrollViewer), you must explicitly disable support for manipulation events on the element in the view by calling [UIElement.CancelDirectmanipulation()](../microsoft.ui.xaml/uielement_canceldirectmanipulations_1164631120.md). To re-enable manipulation events in the view, call [UIElement.TryStartDirectManipulation()](/uwp/api/windows.ui.xaml.uielement.trystartdirectmanipulation(windows.ui.xaml.input.pointer)).

## -examples

## -see-also

[RangeBase](rangebase.md)
