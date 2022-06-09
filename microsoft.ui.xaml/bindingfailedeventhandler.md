---
-api-id: T:Microsoft.UI.Xaml.BindingFailedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void BindingFailedEventHandler(System.Object sender, Windows.UI.Xaml.BindingFailedEventArgs e)
-->
# Microsoft.UI.Xaml.BindingFailedEventHandler

## -description
Represents the method that will handle the [DebugSettings.BindingFailed](debugsettings_bindingfailed.md) event.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param sender
The source of the event.

### -param e
The event data.


## -remarks
[IsBindingTracingEnabled](debugsettings_isbindingtracingenabled.md) must be **true** and there must be a debugger attached to the app process in order for [BindingFailed](debugsettings_bindingfailed.md) to occur and for tracing to appear in debugger output. You don't need to handle the event in order to see tracing appear in a debugger. The debugger output contains message information that goes to the **Output** window of the debugger. Attaching a [BindingFailed](debugsettings_bindingfailed.md) handler yourself is an advanced scenario for when you want to see the raw message.

## -examples

## -see-also
[BindingFailed](debugsettings_bindingfailed.md), [DebugSettings](debugsettings.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
