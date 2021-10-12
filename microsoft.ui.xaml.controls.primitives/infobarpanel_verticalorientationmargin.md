---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.InfoBarPanel.VerticalOrientationMargin
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Controls.Primitives.InfoBarPanel.VerticalOrientationMargin

<!--
see GetVerticalOrientationMargin, and SetVerticalOrientationMargin
-->

## -description

The margin of the [InfoBarPanel](infobarpanel.md) when its items are vertically aligned. This property is reserved for internal use and is not intended to be used in your code.

## -remarks

The VerticalOrientationMargin is applied on an element in addition to the element's Margin property.

However, the leading and trailing margins are ignored. The VerticalOrientationMargin.Top is ignored on the first child, and the VerticalOrientationMargin.Bottom is ignored on the last child. This applies to the first/last child that are not collapsed (that take up layout space). For example, if the first child is collapsed, it's the VerticalOrientationMargin.Top of the second child that is ignored.

## -see-also

## -examples
