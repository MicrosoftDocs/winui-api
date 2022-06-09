---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetPeerFromPoint(Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Automation.Peers.AutomationPeer GetPeerFromPoint(Windows.Foundation.Point point)
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetPeerFromPoint

## -description
Gets an [AutomationPeer](automationpeer.md) from the specified point.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param point
The relative position of the target UI element in the UI.

## -returns
The [AutomationPeer](automationpeer.md) for the UI element at the specified point.

## -remarks
This method is a utility for hit testing practical UI coordinates, evaluating the corresponding UI element, and returning the peer that corresponds to the hit-tested UI element.

## -examples

## -see-also
