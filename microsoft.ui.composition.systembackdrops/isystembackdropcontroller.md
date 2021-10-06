---
-api-id: T:Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropController
-api-type: winrt interface
---

# Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropController

<!--
public interface ISystemBackdropController : System.IDisposable
-->

## -description

Provides methods to connect a system backdrop controller to a window.

## -remarks

A _system backdrop_ is essentially a [CompositionBrush](../microsoft.ui.composition/compositionbrush.md) that defines a [UI material](/windows/apps/design/signature-experiences/materials) such as [Acrylic](/windows/apps/design/style/acrylic) or [Mica](/windows/apps/design/style/mica). This brush is drawn by the system compositor. A _system backdrop controller_ is an object that encapsulates both the rendering of the system backdrop material as well as the handling of system policy for the given material. Each material has its own controller.

You can draw a material at the back of your content by creating the corresponding `ISystemBackdropController` and providing your window and [CompositionTarget](/uwp/api/windows.ui.composition.compositiontarget) to the controller's [SetTarget](/windows/winui/api/microsoft.ui.composition.systembackdrops.isystembackdropcontroller.settarget) method. If `SetTarget` succeeds and returns `true`, and the controller takes care of all material handling, including fallback rendering and all system policies. If `SetTarget` fails and returns `false`, it means the controller was unable to set up the desired material as a system backdrop, and no changes have been made to the `CompositionTarget`.

Materials are drawn using the [Windows.UI.Composition](/uwp/api/windows.ui.composition) APIs, so a [CompositionTarget](/uwp/api/windows.ui.composition.compositiontarget) is required on which the material will be drawn at the very back behind the rest of the app content. Any app content that has transparency will show through to the chosen material.

## -see-also

## -examples

This example shows how to draw the new Windows 11 Mica material in a Win32 app window using C++/WinRT.

```cppwinrt
bool SetupBackdrop(winrt::Microsoft::UI::WindowId windowId, winrt::Windows::UI::Composition::CompositionTarget compositionTarget)
{
    winrt::Microsoft::UI::Composition::SystemBackdrops::MicaController micaController = winrt::MicaController();
    return micaController.SetTarget(windowId, compositionTarget);
}
```
