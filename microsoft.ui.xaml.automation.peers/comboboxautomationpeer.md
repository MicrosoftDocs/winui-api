---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBoxAutomationPeer : Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer, Windows.UI.Xaml.Automation.Peers.IComboBoxAutomationPeer, Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider, Windows.UI.Xaml.Automation.Provider.IValueProvider, Windows.UI.Xaml.Automation.Provider.IWindowProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer

## -description
Exposes [ComboBox](../microsoft.ui.xaml.controls/combobox.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [ComboBox](../microsoft.ui.xaml.controls/combobox.md) class creates a new ComboBoxAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ComboBoxAutomationPeer if you are deriving a custom class from [ComboBox](../microsoft.ui.xaml.controls/combobox.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ComboBoxAutomationPeer**

ComboBoxAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for these patterns:
+ [PatternInterface.Value](patterninterface.md) ([IValueProvider](../microsoft.ui.xaml.automation.provider/ivalueprovider.md))
+ [PatternInterface.Selection](patterninterface.md) ([ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md))
+ [PatternInterface.ItemContainer](patterninterface.md) ([IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md))
+ [PatternInterface.ExpandCollapse](patterninterface.md) ([IExpandCollapseProvider](../microsoft.ui.xaml.automation.provider/iexpandcollapseprovider.md))
 This is the accumulated pattern support from each of the peer base classes and ComboBoxAutomationPeer itself.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ComboBox".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ComboBox](automationcontroltype.md).
+ [GetChildren](automationpeer_getchildren_555647254.md) provides peers for contained elements. See [ComboBoxItemAutomationPeer](comboboxitemautomationpeer.md).
This peer has the base classes [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) and [SelectorAutomationPeer](selectorautomationpeer.md) and these peers also have behavior that isn't overridden by the notes above. For more info, see [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) and [SelectorAutomationPeer](selectorautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

[IsReadOnly](comboboxautomationpeer_isreadonly.md) and [IsEnabled](automationpeer_isenabled_180154405.md) return a calculated value based on UI properties such as [IsEnabled](../microsoft.ui.xaml.controls/control_isenabled.md) on the owner.

The peer can fire the automation events when [ExpandCollapseState](comboboxautomationpeer_expandcollapsestate.md) of the peer and owner control changes.

## -examples

## -see-also
[ComboBox](../microsoft.ui.xaml.controls/combobox.md), [SelectorAutomationPeer](selectorautomationpeer.md), [IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md), [ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md), [IValueProvider](../microsoft.ui.xaml.automation.provider/ivalueprovider.md), [IExpandCollapseProvider](../microsoft.ui.xaml.automation.provider/iexpandcollapseprovider.md), [ItemsControlAutomationPeer](itemscontrolautomationpeer.md), [ComboBoxItemAutomationPeer](comboboxitemautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
