---
-api-id: P:Microsoft.UI.Xaml.Controls.VirtualizingStackPanel.IsVirtualizingProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty IsVirtualizingProperty { get; }
-->

# Microsoft.UI.Xaml.Controls.VirtualizingStackPanel.IsVirtualizingProperty

## -description
Identifies the **VirtualizingStackPanel.IsVirtualizing** attached property.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The identifier for the **VirtualizingStackPanel.IsVirtualizing** attached property.

## -remarks
**VirtualizingStackPanel.IsVirtualizing** is an atypical attached property because it does not have a **Set** accessor, and thus is not really a XAML attached property with a markup usage. Instead, **VirtualizingStackPanel.IsVirtualizing** functions as a sentinel whereby child elements can query the [VirtualizingStackPanel](virtualizingstackpanel.md) parent, and determine whether virtualization is being used. This might be important information for layout logic or further virtualization logic that is used by the child element itself.

## -examples

## -see-also
