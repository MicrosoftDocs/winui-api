---
-api-id: M:Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap.GetPixelsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> GetPixelsAsync()
-->

# Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap.GetPixelsAsync

## -description
Retrieves the previously rendered [RenderTargetBitmap](rendertargetbitmap.md) image as a buffered stream of bytes in **BGRA8** format.

## -returns
An asynchronous operation object from which, on successful completion, you can retrieve an [IBuffer](/uwp/api/windows.storage.streams.ibuffer) stream that contains bytes. This is the binary data for the image and can be converted to a byte array in **BGRA8** format

## -remarks
The [IBuffer](/uwp/api/windows.storage.streams.ibuffer) return value enables passing the result to a [WriteableBitmap](writeablebitmap.md) and its [PixelBuffer](writeablebitmap_pixelbuffer.md). Another alternative is passing the buffer to a [BitmapEncoder](/uwp/api/windows.graphics.imaging.bitmapencoder). If you want an array of bytes, use a [DataReader](/uwp/api/windows.storage.streams.datareader) and the [FromBuffer](/uwp/api/windows.storage.streams.datareader.frombuffer(windows.storage.streams.ibuffer)) method to help with the conversion.

Through the [IAsyncOperation](/uwp/api/windows.foundation.iasyncoperation`1) intermediate value, this method returns the pixels of the image source that was produced by the most recent call to [RenderAsync](rendertargetbitmap_renderasync_318933921.md).

Always call [RenderAsync](rendertargetbitmap_renderasync_318933921.md) before calling GetPixelsAsync. If you call GetPixelsAsync and never called [RenderAsync](rendertargetbitmap_renderasync_318933921.md) previously on that [RenderTargetBitmap](rendertargetbitmap.md) instance, GetPixelsAsync will return an empty buffer stream, and no error will occur (async [Status](/uwp/api/windows.foundation.iasyncinfo.status) is **Completed**, so you can't use that as an indicator).

## -examples

## -see-also
[BitmapEncoder](/uwp/api/windows.graphics.imaging.bitmapencoder), [DataTransferManager](/uwp/api/windows.applicationmodel.datatransfer.datatransfermanager), [Windows.Graphics.Imaging namespace](/uwp/api/windows.graphics.imaging), [XAML render to bitmap sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20render%20to%20bitmap%20sample)
