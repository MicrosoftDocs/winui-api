---
-api-id: P:Microsoft.UI.Xaml.Window.Current
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Window Current { get; }
-->

# Microsoft.UI.Xaml.Window.Current

## -description

For UWP apps, gets the window of the current thread. Desktop apps always return null.

## -property-value

The currently activated window for UWP apps. Null for Desktop apps.

## -remarks

The value of this property depends on the thread from which it is called. If called from a UI thread of a UWP app, the value is the Window instance for that thread. On any other thread, the value is null.

The [Window](window.md) object implements [IWindowNative](/windows/apps/winui/reference/iwindownative), through which Desktop apps can get the underlying HWND of the window.

## -examples

## -see-also

[IWindowNative](/windows/apps/winui/reference/iwindownative)
