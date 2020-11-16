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

## -parameters
### -param args
The [ProcessKeyboardAcceleratorEventArgs](..\windows.ui.xaml.input\processkeyboardacceleratoreventargs.md).

## -remarks
Call this method in the [OnProcessKeyboardAccelerators](flyoutbase_onprocesskeyboardaccelerators_490218500.md) override when an accelerator is invoked and you want to influence the default accelerator handling.

## -examples

## -see-also

[ProcessKeyboardAccelerators](uielement_processkeyboardaccelerators.md)
