---
-api-id: M:Microsoft.UI.Xaml.Controls.ScrollViewer.RegisterAnchorCandidate(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void ScrollViewer.RegisterAnchorCandidate(UIElement element)
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.RegisterAnchorCandidate

## -description

Registers a [UIElement](../microsoft.ui.xaml/uielement.md) as a potential scroll anchor.

## -parameters

### -param element

A [UIElement](../microsoft.ui.xaml/uielement.md) within the subtree of the [ScrollViewer](scrollviewer.md).

## -remarks

When an element has [CanBeScrollAnchor](../microsoft.ui.xaml/uielement_canbescrollanchor.md) set to **true** the framework locates the first [IScrollAnchorProvider](iscrollanchorprovider.md) in that element's chain of ancestors and automatically calls its RegisterAnchorCandidate method. This occurs both when the property is set on an existing element or an element is added to the live tree with the property already set.

Similarly, when the property is set to **false** (or an element is removed from the visual tree with the property set to true), the framework calls the [UnregisterAnchorCandidate](iscrollanchorprovider_unregisteranchorcandidate_1598248032.md) on the first [IScrollAnchorProvider](iscrollanchorprovider.md).

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md), [UnregisterAnchorCandidate](iscrollanchorprovider_unregisteranchorcandidate_1598248032.md), [CanBeScrollAnchor](../microsoft.ui.xaml/uielement_canbescrollanchor.md)

## -examples
