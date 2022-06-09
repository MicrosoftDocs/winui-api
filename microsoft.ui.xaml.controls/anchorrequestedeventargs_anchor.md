---
-api-id: P:Microsoft.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Anchor { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor

## -description

Gets or sets the *anchor element* to use when performing scroll anchoring.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The [UIElement](../microsoft.ui.xaml/uielement.md) to use as the [CurrentAnchor](iscrollanchorprovider_currentanchor.md). The default is **null**.

## -remarks

The element must be a descendent of the scrolling control.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md), [ScrollViewer.AnchorRequested](scrollviewer_anchorrequested.md)

## -examples

