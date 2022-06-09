---
-api-id: T:Microsoft.UI.Xaml.BindingFailedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class BindingFailedEventArgs : Windows.UI.Xaml.IBindingFailedEventArgs
-->

# Microsoft.UI.Xaml.BindingFailedEventArgs

## -description
Provides event data for the [DebugSettings.BindingFailed](debugsettings_bindingfailed.md) event.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
BindingFailedEventArgs is used for debugging bindings, using a technique that you shouldn't include in production code. Wire the event handler using [DebugSettings](application_debugsettings.md), and use this data class as the result in your handler. You'll mainly be interested in the [Message](bindingfailedeventargs_message.md) value, which you could log or send to **Debug** output.

## -examples

## -see-also
[DebugSettings.BindingFailed](debugsettings_bindingfailed.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
