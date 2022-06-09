---
-api-id: E:Microsoft.UI.Xaml.Controls.ListViewBase.ChoosingGroupHeaderContainer
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ChoosingGroupHeaderContainer<Windows.UI.Xaml.Controls.ListViewBase,  Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs>
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.ChoosingGroupHeaderContainer

## -description
Occurs when an item container is to be chosen for a data group.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
You typically handle this event to enable accessibility. The group headers do not have an accessible name set by default. This event provides access to the header instance and lets you to set the [AutomationProperties.Name](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property to an appropriate value.

## -examples

## -see-also
