---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IListViewItemAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer

## -description
Exposes a [ListViewItem](../microsoft.ui.xaml.controls/listviewitem.md) to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [ListViewItem](../microsoft.ui.xaml.controls/listviewitem.md) class creates a new ListViewItemAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ListViewItemAutomationPeer if you are deriving a custom class from [ListViewItem](../microsoft.ui.xaml.controls/listviewitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ListViewItemAutomationPeer**

ListViewItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) defers to base peers. [GetPattern](automationpeer_getpattern_1700082720.md) returns a pattern for [IDragProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idragprovider) though an internal base class. The content of the [ListViewItem](../microsoft.ui.xaml.controls/listviewitem.md) might also have a specific peer, for example if it is a [TextBox](../microsoft.ui.xaml.controls/textbox.md). The parent [ListView](../microsoft.ui.xaml.controls/listview.md) has the support for any selection-related automation behavior.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ListViewItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
<!--mysterious do not see the code that does this-->
+ Because a [ListViewItem](../microsoft.ui.xaml.controls/listviewitem.md) is a [ContentControl](../microsoft.ui.xaml.controls/contentcontrol.md), [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. This is implemented so that consumers of the control don't always need to provide an [AutomationProperties.Name](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) value in app code, and can use a generated-from-content value for the automation **Name** directly from the UI definition. For more info on how this works, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ListView](../microsoft.ui.xaml.controls/listview.md), [ListViewItem](../microsoft.ui.xaml.controls/listviewitem.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
