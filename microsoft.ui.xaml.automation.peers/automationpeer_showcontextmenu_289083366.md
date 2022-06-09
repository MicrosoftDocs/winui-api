---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.ShowContextMenu
-api-type: winrt method
---

<!-- Method syntax
public void ShowContextMenu()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.ShowContextMenu

## -description
Shows the available context menu for the owner element.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
Calling ShowContextMenu throws an error if a context menu cannot be shown. If no context menu is available directly on the element on which it was invoked, the Microsoft UI Automation logic implemented by a provider should attempt to show a context menu for the Microsoft UI Automation tree parent of the element.

Scenarios for invoking a context menu from an element include auto-correction and spelling alternatives for text input. The UI elements that display these are not part of the default tab sequence and are not part of an initial Microsoft UI Automation tree until the context that requires them is detected.

## -examples

## -see-also
