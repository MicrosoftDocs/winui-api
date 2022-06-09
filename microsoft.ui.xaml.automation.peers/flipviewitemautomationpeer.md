---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.FlipViewItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class FlipViewItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IFlipViewItemAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.FlipViewItemAutomationPeer

## -description
Exposes a [FlipViewItem](../microsoft.ui.xaml.controls/flipviewitem.md) to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [FlipViewItem](../microsoft.ui.xaml.controls/flipviewitem.md) class creates a new FlipViewItemAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from FlipViewItemAutomationPeer if you are deriving a custom class from [FlipViewItem](../microsoft.ui.xaml.controls/flipviewitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **FlipViewItemAutomationPeer**

FlipViewItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer doesn't have any patterns. However, the content of the [FlipViewItem](../microsoft.ui.xaml.controls/flipviewitem.md) might have a specific peer, for example if it is a [TextBox](../microsoft.ui.xaml.controls/textbox.md). The parent [FlipView](../microsoft.ui.xaml.controls/flipview.md) has the support for any selection-related automation behavior.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "FlipViewItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [FlipView](../microsoft.ui.xaml.controls/flipview.md), [FlipViewItem](../microsoft.ui.xaml.controls/flipviewitem.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
