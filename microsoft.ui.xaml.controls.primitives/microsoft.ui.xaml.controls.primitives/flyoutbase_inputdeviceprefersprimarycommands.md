---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.InputDevicePrefersPrimaryCommands
-api-type: winrt property
---

<!-- Property syntax.
public bool InputDevicePrefersPrimaryCommands { get; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.InputDevicePrefersPrimaryCommands

## -description

Gets a value that indicates whether the input device used to open the flyout does not easily open the secondary commands.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

**true** if the input device used to open the flyout does not easily open the secondary commands; otherwise, **false**.

## -remarks

Some input devices, such as touch or gaze, do not easily open the secondary commands menu, which requires a click in the open flyout. In these cases, you can move commands from the secondary command menu to the primary command bar to provide easier access using these inputs.

## -see-also

## -examples

