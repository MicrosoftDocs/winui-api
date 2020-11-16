---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewer.CurrentAnchor
-api-type: winrt property
---

<!-- Property syntax.
public UIElement CurrentAnchor { get; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.CurrentAnchor

## -description

The currently chosen anchor element to use for scroll anchoring.

## -property-value

The most recently chosen [UIElement](../microsoft.ui.xaml/uielement.md) for scroll anchoring after a layout pass, or **null**.

## -remarks

If there are no anchor candidates registered with the [ScrollViewer](scrollviewer.md) or none have been chosen, then CurrentAnchor is **null**.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md)

## -examples
