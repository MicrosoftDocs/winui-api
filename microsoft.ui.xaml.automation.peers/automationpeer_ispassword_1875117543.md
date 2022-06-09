---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsPassword
-api-type: winrt method
---

<!-- Method syntax
public bool IsPassword()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsPassword

## -description
Gets a value that indicates whether the element contains sensitive content.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
**true** if the element contains sensitive content such as a password; otherwise, **false**.

## -remarks
This property enables applications such as screen readers to determine whether the text content of a control should be read aloud.


<!--This remark taken from the RTM .NET documentation. I don't think you should shorten 'applications' to 'apps' here because screen readers are desktop applications that well predate Windows 8; there will probably never be a true screen reader "app" because it requires system integration that the Windows 8 appmodel will never make available to a developer.-->

## -examples

## -see-also
