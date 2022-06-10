---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.TryInvokeKeyboardAccelerator(Microsoft.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs)
-api-type: winrt method
---

<!-- Method syntax.
public void FlyoutBase.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)
-->

# Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.TryInvokeKeyboardAccelerator

## -description
Attempts to invoke a keyboard shortcut (accelerator).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param args
The [ProcessKeyboardAcceleratorEventArgs](..\windows.ui.xaml.input\processkeyboardacceleratoreventargs.md).

## -remarks
Call this method in the [OnProcessKeyboardAccelerators](flyoutbase_onprocesskeyboardaccelerators_490218500.md) override when an accelerator is invoked and you want to influence the default accelerator handling.

## -examples

## -see-also

[ProcessKeyboardAccelerators](uielement_processkeyboardaccelerators.md)
