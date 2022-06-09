---
-api-id: M:Microsoft.UI.Xaml.Media.LoadedImageSurface.StartLoadFromStream(Windows.Storage.Streams.IRandomAccessStream,Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax.
public LoadedImageSurface LoadedImageSurface.StartLoadFromStream(IRandomAccessStream stream, Size desiredMaxSize)
-->

# Microsoft.UI.Xaml.Media.LoadedImageSurface.StartLoadFromStream


## -description

Loads an image into a [LoadedImageSurface](loadedimagesurface.md) from the provided [IRandomAccessStream](/uwp/api/windows.storage.streams.irandomaccessstream) with the desired maximum size.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters

### -param stream

The stream from which the image is loaded.

### -param desiredMaxSize

The desired maximum size of the image surface in device independent pixels.

## -returns

An instance of [LoadedImageSurface](loadedimagesurface.md) with the image loaded onto its surface.

## -remarks

By default, [LoadedImageSurface](loadedimagesurface.md) will fill up as much of the **desiredMaxSize** as possible while preserving the aspect ratio and image content
of the incoming source. This may result in a decodedsize that differs from the input **desiredMaxSize**

## -see-also

## -examples

