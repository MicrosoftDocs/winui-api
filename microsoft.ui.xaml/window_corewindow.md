---
-api-id: P:Microsoft.UI.Xaml.Window.CoreWindow
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Core.CoreWindow CoreWindow { get; }
-->

# Microsoft.UI.Xaml.Window.CoreWindow

## -description

For UWP apps, gets the [CoreWindow](https://docs.microsoft.com/uwp/api/Windows.UI.Core.CoreWindow) associated with this Window. Desktop apps always return null.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

A **CoreWindow** object for UWP apps. Null for Desktop apps.

## -remarks

The [Window](window.md) object implements [IWindowNative](/windows/apps/winui/reference/iwindownative), through which Desktop apps can get the underlying HWND of the Window.

## -examples

## -see-also

[IWindowNative](/windows/apps/winui/reference/iwindownative)
