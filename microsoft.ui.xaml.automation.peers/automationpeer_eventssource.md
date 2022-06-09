---
-api-id: P:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.EventsSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Automation.Peers.AutomationPeer EventsSource { get;  set; }
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.EventsSource

## -description
Gets or sets an [AutomationPeer](automationpeer.md) that is reported to the automation client as the source for all the events that come from this [AutomationPeer](automationpeer.md). See Remarks.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The [AutomationPeer](automationpeer.md) that is the source of events.

## -remarks
EventsSource is typically set by [AutomationPeer](automationpeer.md) implementations in cases where the automation provider element is a child element of another element that also has a peer, and the best automation experience for clients is to treat the parent as the source for automation events. In such cases, the child element's peer implementation sets EventsSource to return the [AutomationPeer](automationpeer.md) of the parent element.

## -examples

## -see-also
