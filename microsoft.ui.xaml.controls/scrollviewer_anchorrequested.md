---
-api-id: E:Microsoft.UI.Xaml.Controls.ScrollViewer.AnchorRequested
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler AnchorRequested<ScrollViewer, AnchorRequestedEventArgs>
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.AnchorRequested

## -description

Occurs when an anchor is requested at the beginning of the Arrange pass. Handle this event to override the ScrollViewer's default logic to select an anchor element as part of *scroll anchoring*.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

Explicitly set the [Anchor](anchorrequestedeventargs_anchor.md) property of the [AnchorRequestedEventArgs](anchorrequestedeventargs.md) to a UIElement within the [ScrollViewer](scrollviewer.md)'s subtree to override the default policy of choosing an anchor element.  The [AnchorCandidates](anchorrequestedeventargs_anchorcandidates.md) property provides the list of candidates currently registered with the [ScrollViewer](scrollviewer.md).

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md)

## -examples
