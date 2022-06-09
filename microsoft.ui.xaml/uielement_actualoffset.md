---
-api-id: P:Microsoft.UI.Xaml.UIElement.ActualOffset
-api-type: winrt property
---

<!-- Property syntax.
public Vector3 ActualOffset { get; }
-->

# Microsoft.UI.Xaml.UIElement.ActualOffset

## -description

Gets the position of this UIElement, relative to its parent, computed during the arrange pass of the layout process.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The position of this UIElement, relative to its parent, computed during the arrange pass of the layout process.

## -remarks

ActualOffset can be used as an input property to an [ExpressionAnimation](../microsoft.ui.composition/expressionanimation.md).

The _z_ value of the offset is always 0.

## -see-also

## -examples

