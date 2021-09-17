---
-api-id: P:Microsoft.UI.Windowing.AppWindow.IsVisible
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindow.IsVisible

<!--
public bool IsVisible { get; }
-->

## -description

Gets a value that indicates whether the window is shown.

## -property-value

`true` if the window is shown; otherwise, `false`.

## -remarks

A window is considered shown (visible) even when other windows are occluding it. The behavior of this property aligns with the [IsWindowVisible](/windows/win32/api/winuser/nf-winuser-iswindowvisible) function.

## -see-also

[AppWindow](appwindow.md), [AppWindow.Show](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindow.show), [AppWindow.Hide](appwindow_hide_1985563870.md), [IsWindowVisible (Win32)](/windows/win32/api/winuser/nf-winuser-iswindowvisible)

## -examples
