---
-api-id: M:Microsoft.UI.Windowing.AppWindow.Resize(Windows.Graphics.SizeInt32)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.Resize(Windows.Graphics.SizeInt32)

<!--
public bool Resize (Windows.Graphics.SizeInt32 size);
-->

## -description

Resizes the window to the specified size.

## -parameters

### -param size

The height and width of the window in screen coordinates.

## -returns

`true` if the window was changed to the specified size; otherwise, `false`.

## -remarks

After the window size has changed a [Changed](appwindow_changed.md) event will occur.

_Screen coordinates_ are relative to the upper-left corner of the screen; the coordinates of the upper-left corner are (0,0).

## -see-also

[AppWindow](appwindow.md), [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system), [Windows Forms coordinates](/dotnet/desktop/winforms/windows-forms-coordinates), [Move](appwindow_move_893940313.md), [MoveAndResize](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindow.moveandresize)

## -examples
