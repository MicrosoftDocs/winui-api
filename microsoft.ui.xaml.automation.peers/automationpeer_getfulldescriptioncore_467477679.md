---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetFullDescriptionCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetFullDescriptionCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetFullDescriptionCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetFullDescription](automationpeer_getfulldescription_2065753949.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
A localized string that describes the actual visual appearance or contents of something such as an image or image control.

## -remarks
You should never invoke the base behavior, and all custom peers should override GetFullDescriptionCore to report the full description of this [AutomationPeer](automationpeer.md). For more info, see [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
