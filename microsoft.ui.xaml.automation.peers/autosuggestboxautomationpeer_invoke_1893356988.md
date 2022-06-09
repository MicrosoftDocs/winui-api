---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer.Invoke
-api-type: winrt method
---

<!-- Method syntax.
public void AutoSuggestBoxAutomationPeer.Invoke()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer.Invoke

## -description
Sends a request to submit the auto-suggest query to the [AutoSuggestBox](../microsoft.ui.xaml.controls/autosuggestbox.md) associated with the automation peer. 

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
Calls to **Invoke** should return immediately without blocking. However, this behavior is entirely dependent on the Microsoft UI Automation provider implementation. In scenarios where calling **Invoke** causes a blocking issue, such as a modal dialog, a separate helper thread may be required to call the method.  

## -see-also

## -examples

