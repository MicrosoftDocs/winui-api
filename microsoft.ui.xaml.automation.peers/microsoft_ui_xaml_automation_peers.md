---
-api-id: N:Microsoft.UI.Xaml.Automation.Peers
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Microsoft.UI.Xaml.Automation.Peers 
-->

# Microsoft.UI.Xaml.Automation.Peers

## -description

Defines support types for the [Microsoft UI Automation](/windows/win32/winauto/entry-uiauto-win32) infrastructure.

> [!NOTE]
> This namespace requires the **Microsoft.UI.Xaml.Controls** NuGet package, a part of the [Microsoft Windows UI Library](https://aka.ms/winui-docs).

## -remarks

WinUI controls, and other UI elements, implement UI Automation support to report roles and values. You can use UI Automation tools to examine the role and value information, or you can review the AutomationPeer implementations of each control. The available roles in a UI Automation framework are defined in the [AutomationControlType](/uwp/api/Windows.UI.Xaml.Automation.Peers.AutomationControlType) enumeration. UI Automation clients, such as assistive technologies, can obtain role information by calling methods that the UI Automation framework exposes through the control's AutomationPeer.

## -see-also

[Custom automation peers](/windows/uwp/design/accessibility/custom-automation-peers), [Expose basic accessibility information](/windows/uwp/design/accessibility/basic-accessibility-information), [Accessibility Insights](https://accessibilityinsights.io/)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, [open the app for a demonstration of how  Narrator interacts with various AutomationProperties](xamlcontrolsgallery:/item/AutomationProperties).

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
