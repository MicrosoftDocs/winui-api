---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetHeadingLevel
-api-type: winrt method
---

<!-- Method syntax.
public AutomationHeadingLevel AutomationPeer.GetHeadingLevel()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetHeadingLevel

## -description
Gets the heading level of the UI Automation element that is associated with this automation peer.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
The text heading level.

## -remarks
Heading elements organize the user interface and make it easier to navigate. Some assistive technology (AT) allows users to quickly jump between headings. Headings have a level from 1 to 9.  

![Mouse settings page in Windows Ease of Access settings](images/MouseSettings.png)

Examples of headings would be section titles within the Windows Settings app. For instance, under the **Ease of Access** -> **Mouse** page, **Pointer size**, **Pointer color**, and **Mouse keys** would be a heading of level 1.

## -see-also
[AutomationHeadingLevel](automationheadinglevel.md), [GetHeadingLevelCore](automationpeer_getheadinglevelcore_1105552106.md)

## -examples

