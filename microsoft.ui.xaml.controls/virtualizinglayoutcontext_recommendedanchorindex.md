---
-api-id: P:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.RecommendedAnchorIndex
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.RecommendedAnchorIndex

<!--
public int RecommendedAnchorIndex { get; }
-->

## -description

Gets the recommended index from which to start the generation and layout of elements.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The recommended index from which the layout should start.

## -remarks

The recommended index might be the result of programmatically realizing an element and requesting that it be brought into view. Or, it may be that a user drags the scrollbar thumb so quickly that the new viewport and the viewport & buffer previously given to the layout do not intersect, so a new index is suggested as the anchor from which to generate and layout other elements.

## -see-also

## -examples

