---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.PasswordBoxAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class PasswordBoxAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IPasswordBoxAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.PasswordBoxAutomationPeer

## -description
Exposes [PasswordBox](../microsoft.ui.xaml.controls/passwordbox.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [PasswordBox](../microsoft.ui.xaml.controls/passwordbox.md) class creates a new PasswordBoxAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [PasswordBox](../microsoft.ui.xaml.controls/passwordbox.md) is sealed, so the normal scenario of deriving from the [PasswordBox](../microsoft.ui.xaml.controls/passwordbox.md) class and its existing peer isn't applicable to PasswordBoxAutomationPeer.

### Default peer implementation and overrides in **PasswordBoxAutomationPeer**

PasswordBoxAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports no pattern support.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "PasswordBox".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Edit](automationcontroltype.md).
+ [IsPassword](automationpeer_ispassword_1875117543.md) returns **true**.
An automation **Name** is not calculated for you for [PasswordBox](../microsoft.ui.xaml.controls/passwordbox.md) content. You should assign a value using the [AutomationProperties.Name](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property.

Any value entered for a password is potentially sensitive information and is often handled differently from a normal edit box by assistive technology implementations. For example a screen reader might not read characters aloud when [IsPassword](automationpeer_ispassword_1875117543.md) returns **true**.

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [PasswordBox](../microsoft.ui.xaml.controls/passwordbox.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
