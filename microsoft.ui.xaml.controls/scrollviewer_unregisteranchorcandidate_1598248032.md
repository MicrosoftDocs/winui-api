---
-api-id: M:Microsoft.UI.Xaml.Controls.ScrollViewer.UnregisterAnchorCandidate(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void ScrollViewer.UnregisterAnchorCandidate(UIElement element)
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.UnregisterAnchorCandidate

## -description

Unregisters a [UIElement](../microsoft.ui.xaml/uielement.md) as a potential scroll anchor.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param element

A [UIElement](../microsoft.ui.xaml/uielement.md) within the subtree of the [ScrollViewer](scrollviewer.md).

## -remarks

When an element's [CanBeScrollAnchor](../microsoft.ui.xaml/uielement_canbescrollanchor.md) property changes to **false** (or the element is removed from the visual tree), the framework locates the first [IScrollAnchorProvider](iscrollanchorprovider.md) in that element's chain of ancestors and automatically calls its UnregisterAnchorCandidate method.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md), [RegisterAnchorCandidate](iscrollanchorprovider_registeranchorcandidate_1915074492.md), [CanBeScrollAnchor](../microsoft.ui.xaml/uielement_canbescrollanchor.md)

## -examples

