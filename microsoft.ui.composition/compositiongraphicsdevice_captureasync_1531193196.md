---
-api-id: M:Microsoft.UI.Composition.CompositionGraphicsDevice.CaptureAsync(Microsoft.UI.Composition.Visual,Windows.Graphics.SizeInt32,Microsoft.Graphics.DirectX.DirectXPixelFormat,Microsoft.Graphics.DirectX.DirectXAlphaMode,System.Single)
-api-type: winrt method
---

# Microsoft.UI.Composition.CompositionGraphicsDevice.CaptureAsync(Microsoft.UI.Composition.Visual,Windows.Graphics.SizeInt32,Microsoft.Graphics.DirectX.DirectXPixelFormat,Microsoft.Graphics.DirectX.DirectXAlphaMode,System.Single)

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.UI.Composition.ICompositionSurface> CaptureAsync (Microsoft.UI.Composition.Visual captureVisual, Windows.Graphics.SizeInt32 size, Microsoft.Graphics.DirectX.DirectXPixelFormat pixelFormat, Microsoft.Graphics.DirectX.DirectXAlphaMode alphaMode, float sdrBoost);
-->


## -description

Captures various source elements, including visual trees owned by an application, to a composition surface.

## -parameters

### -param captureVisual

The visual to capture.

### -param size

The size in pixels of the surface.

### -param pixelFormat

The pixel format of the surface.

### -param alphaMode

How the alpha channel should be handled.

### -param sdrBoost

The amount to boost SDR.

## -returns

An asynchronous operation that returns an `ICompositionSurface` upon successful completion.

## -remarks

## -see-also

## -examples


