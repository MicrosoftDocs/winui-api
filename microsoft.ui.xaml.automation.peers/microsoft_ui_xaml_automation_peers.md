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

[Custom automation peers](/windows/apps/design/accessibility/custom-automation-peers), [Expose basic accessibility information](/windows/apps/design/accessibility/basic-accessibility-information), [Accessibility Insights](https://accessibilityinsights.io/)

## -examples

> [!TIP]
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/AutomationProperties) or [**WinUI 2 Gallery**](winui2gallery:/item/AutomationProperties).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

