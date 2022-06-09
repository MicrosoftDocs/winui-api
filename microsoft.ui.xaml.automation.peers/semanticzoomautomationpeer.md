---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class SemanticZoomAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.ISemanticZoomAutomationPeer, Windows.UI.Xaml.Automation.Provider.IToggleProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer

## -description
Exposes [SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md) class creates a new SemanticZoomAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md) is sealed, so the normal scenario of deriving from the [SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md) class and its existing peer isn't applicable to SemanticZoomAutomationPeer.

### Default peer implementation and overrides in **SemanticZoomAutomationPeer**

SemanticZoomAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for [PatternInterface.Toggle](patterninterface.md) ([IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "SemanticZoom".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.SemanticZoom](automationcontroltype.md).

> [!NOTE]
> "SemanticZoom" is a relatively recent addition to the Microsoft UI Automation set of automation control types, so not all clients are implemented to look for it.
This peer fires several automation events on behalf of its owner for toggle state changes.

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
