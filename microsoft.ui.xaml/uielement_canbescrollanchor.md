---
-api-id: P:Microsoft.UI.Xaml.UIElement.CanBeScrollAnchor
-api-type: winrt property
---

<!-- Property syntax.
public bool CanBeScrollAnchor { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.CanBeScrollAnchor

## -description

Gets or sets a value that indicates whether the [UIElement](uielement.md) can be a candidate for scroll anchoring.

## -property-value

**true** if an element should be considered as a candidate for scroll anchoring; otherwise, **false**. The default is **false**.

## -remarks

For more info, see the remarks for the [IScrollAnchorProvider](../microsoft.ui.xaml.controls/iscrollanchorprovider.md) interface.

## -see-also

[IScrollAnchorProvider](../microsoft.ui.xaml.controls/iscrollanchorprovider.md), [IScrollAnchorProvider.RegisterAnchorCandidate](/uwp/api/windows.ui.xaml.controls.iscrollanchorprovider.registeranchorcandidate(windows.ui.xaml.uielement)), [IScrollAnchorProvider.UnregisterAnchorCandidate](/uwp/api/windows.ui.xaml.controls.iscrollanchorprovider.unregisteranchorcandidate(windows.ui.xaml.uielement))

## -examples
