---
-api-id: M:Microsoft.UI.Windowing.AppWindow.Move(Windows.Graphics.PointInt32)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.Move(Windows.Graphics.PointInt32)

<!--
public bool Move (Windows.Graphics.PointInt32 position);
-->

## -description

Moves the window to the specified point in screen coordinates.

## -parameters

### -param position

The point to move the window to in screen coordinates.

## -returns

`true` if the window was moved to the specified position; otherwise, `false`.

## -remarks

After the window position has changed a [Changed](appwindow_changed.md) event will occur.

_Screen coordinates_ are relative to the upper-left corner of the screen; the coordinates of the upper-left corner are (0,0).

## -see-also

[AppWindow](appwindow.md), [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system), [Windows Forms coordinates](/dotnet/desktop/winforms/windows-forms-coordinates), [MoveAndResize](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindow.moveandresize), [Resize](appwindow_resize_102971024.md)

## -examples
