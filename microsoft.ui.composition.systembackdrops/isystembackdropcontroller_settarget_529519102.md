---
-api-id: M:Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropController.SetTarget(Microsoft.UI.WindowId,Windows.UI.Composition.CompositionTarget)
-api-type: winrt method
---

# Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropController.SetTarget(Microsoft.UI.WindowId,Windows.UI.Composition.CompositionTarget)

<!--
public bool SetTarget (Microsoft.UI.WindowId windowId, Windows.UI.Composition.CompositionTarget desktopWindowTarget);
-->

## -description

Connects a system backdrop controller to an `HWND` or `AppWindow` with the specified _WindowId_.

## -parameters

### -param windowId

The identifier for the HWND or AppWindow to connect to.

### -param desktopWindowTarget

The composition target to connect to.

## -returns

`true` if the controller was able to set up the material as a system backdrop; otherwise, `false`.

## -remarks

Use this method to connect the `ISystemBackdropController` to a Win32 `HWND` or an [AppWindow](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindow).

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)

## -examples

This example shows how to draw the Mica material in a Win32 app window using C++/WinRT.

```cppwinrt
bool SetupBackdrop(winrt::Microsoft::UI::WindowId windowId, winrt::Windows::UI::Composition::CompositionTarget compositionTarget)
{
    winrt::Microsoft::UI::Composition::SystemBackdrops::MicaController micaController = winrt::MicaController();
    return micaController.SetTarget(windowId, compositionTarget);
}
```
