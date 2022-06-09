---
-api-id: M:Microsoft.UI.Xaml.Media.LoadedImageSurface.Close
-api-type: winrt method
---

<!-- Method syntax.
public void LoadedImageSurface.Close()
-->

# Microsoft.UI.Xaml.Media.LoadedImageSurface.Close


## -description

Disposes of the [LoadedImageSurface](loadedimagesurface.md) and associated resources.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks

Calling this method will dispose the [LoadedImageSurface](loadedimagesurface.md) reference, however any brushes or surfaces created from the **LoadedImageSurface** that still have active references will 
continue to render unless you explicitly dispose of those as well.

## -see-also

## -examples

In this example, the [CompositionSurfaceBrush](../microsoft.ui.composition/compositionsurfacebrush.md) will continue to exist even after the 
[LoadedImageSurface](loadedimagesurface.md) has been closed.

```csharp
Compositor compositor = new Compositor();
CompositionSurfaceBrush imageBrush = compositor.CreateSurfaceBrush();

LoadedImageSurface loadedSurface = LoadedImageSurface.StartLoadFromUri(new Uri("ms-appx:///Assets/myPic.jpg"));
loadedSurface.LoadCompleted += Load_Completed;
imageBrush.Surface = loadedSurface;

loadedSurface.Close();
// The imageBrush still exists

```

