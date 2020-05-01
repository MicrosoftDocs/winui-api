---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsRepeaterScrollHost.CurrentAnchor
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ItemsRepeaterScrollHost.CurrentAnchor

<!--
public Windows.UI.Xaml.UIElement CurrentAnchor { get; }
-->

## -description

The currently chosen anchor element to use for scroll anchoring.

## -property-value

The most recently chosen [UIElement](/uwp/api/windows.ui.xaml.uielement) for scroll anchoring after a layout pass, or **null**.

## -remarks

If there are no anchor candidates registered with the ItemsRepeaterScrollHost or none have been chosen, then CurrentAnchor is **null**.

## -see-also

[CurrentAnchor](/uwp/api/windows.ui.xaml.controls.scrollviewer.currentanchor) 

## -examples

