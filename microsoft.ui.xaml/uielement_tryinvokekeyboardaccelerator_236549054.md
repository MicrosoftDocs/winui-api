---
-api-id: M:Microsoft.UI.Xaml.UIElement.TryInvokeKeyboardAccelerator(Microsoft.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs)
-api-type: winrt method
---

<!-- Method syntax.
public void UIElement.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)
-->

# Microsoft.UI.Xaml.UIElement.TryInvokeKeyboardAccelerator

## -description
Attempts to invoke a [keyboard shortcut (or accelerator)](../microsoft.ui.xaml.input/keyboardaccelerator.md) by searching the entire visual tree of the UIElement for the shortcut.

## -parameters
### -param args
The [ProcessKeyboardAcceleratorEventArgs](../microsoft.ui.xaml.input/processkeyboardacceleratoreventargs.md).

## -remarks
Call this method in your [OnProcessKeyboardAccelerators](uielement_onprocesskeyboardaccelerators_490218500.md) override when an accelerator is invoked and you want to influence the default accelerator handling.

## -examples

## -see-also
[ProcessKeyboardAccelerators](uielement_processkeyboardaccelerators.md), [Keyboard Accelerators](/windows/apps/design/input/keyboard-accelerators)
