---
-api-id: M:Microsoft.UI.Xaml.Controls.IScrollAnchorProvider.UnregisterAnchorCandidate(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void IScrollAnchorProvider.UnregisterAnchorCandidate(UIElement element)
-->

# Microsoft.UI.Xaml.Controls.IScrollAnchorProvider.UnregisterAnchorCandidate

## -description

Unregisters a [UIElement](../microsoft.ui.xaml/uielement.md) as a potential scroll anchor candidate.

## -parameters

### -param element

A [UIElement](../microsoft.ui.xaml/uielement.md) within the subtree of the [IScrollAnchorProvider](iscrollanchorprovider.md).

## -remarks

When an element's [CanBeScrollAnchor](../microsoft.ui.xaml/uielement_canbescrollanchor.md) property changes to **false** (or the element is removed from the visual tree), the framework locates the first [IScrollAnchorProvider](iscrollanchorprovider.md) in that element's chain of ancestors and automatically calls its UnregisterAnchorCandidate method.

## -see-also

[RegisterAnchorCandidate](iscrollanchorprovider_registeranchorcandidate_1915074492.md), [CanBeScrollAnchor](../microsoft.ui.xaml/uielement_canbescrollanchor.md)

## -examples

