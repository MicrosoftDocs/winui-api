---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.HyperlinkButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class HyperlinkButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IHyperlinkButtonAutomationPeer, Windows.UI.Xaml.Automation.Provider.IInvokeProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.HyperlinkButtonAutomationPeer

## -description
Exposes [HyperlinkButton](../microsoft.ui.xaml.controls/hyperlinkbutton.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [HyperlinkButton](../microsoft.ui.xaml.controls/hyperlinkbutton.md) class creates a new HyperlinkButtonAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from HyperlinkButtonAutomationPeer if you are deriving a custom class from [HyperlinkButton](../microsoft.ui.xaml.controls/hyperlinkbutton.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **HyperlinkButtonAutomationPeer**

HyperlinkButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for [PatternInterface.Invoke](patterninterface.md) ([IInvokeProvider](../microsoft.ui.xaml.automation.provider/iinvokeprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Hyperlink".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Hyperlink](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns **true**.
This peer has the immediate base class [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) and inherits its behavior other than the overrides indicated above. Notably, [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. For more info, see [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[HyperlinkButton](../microsoft.ui.xaml.controls/hyperlinkbutton.md), [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md), [IInvokeProvider](../microsoft.ui.xaml.automation.provider/iinvokeprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
