---
-api-id: M:Microsoft.UI.Windowing.AppWindow.MoveAndResize(Windows.Graphics.RectInt32)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.MoveAndResize(Windows.Graphics.RectInt32)

<!--
public bool MoveAndResize (Windows.Graphics.RectInt32 rect);
-->

## -description

Moves the window to the specified point in screen coordinates and sets it to the specified size.

## -parameters

### -param rect

A rectangle that specifies the position and size of the window.

## -returns

`true` if the window was moved to the specified position and size; otherwise, `false`.

## -remarks

_Screen coordinates_ are relative to the upper-left corner of the screen; the coordinates of the upper-left corner are (0,0).

The size and position of the window is described by a `RectInt32` structure. The [X](/uwp/api/windows.graphics.rectint32.x) and [Y](/uwp/api/windows.graphics.rectint32.y) fields specify the position of the upper-left corner of the window in screen coordinates. The [Height](/uwp/api/windows.graphics.rectint32.height) and [Width](/uwp/api/windows.graphics.rectint32.width) fields specify the size of the window.

After the window position or size has changed a [Changed](appwindow_changed.md) event will occur.

## -see-also

[AppWindow](appwindow.md), [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system), [Windows Forms coordinates](/dotnet/desktop/winforms/windows-forms-coordinates), [Move](appwindow_move_893940313.md), [Resize](appwindow_resize_102971024.md)

## -examples
