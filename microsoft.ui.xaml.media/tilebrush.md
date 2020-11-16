---
-api-id: T:Microsoft.UI.Xaml.Media.TileBrush
-api-type: winrt class
---

<!-- Class syntax.
public class TileBrush : Windows.UI.Xaml.Media.Brush, Windows.UI.Xaml.Media.ITileBrush
-->

# Microsoft.UI.Xaml.Media.TileBrush

## -description
Base class that describes a way to paint a region. Parent of [ImageBrush](imagebrush.md).

## -remarks
### **TileBrush** derived classes

TileBrush is the parent class for [ImageBrush](imagebrush.md) and [WebViewBrush](/uwp/api/windows.ui.xaml.controls.webviewbrush). The Windows Runtime XAML vocabulary doesn't support **VideoBrush**. If you're porting Microsoft Silverlight XAML, [WebViewBrush](/uwp/api/windows.ui.xaml.controls.webviewbrush) approximately replaces **WebBrowserBrush**, but be aware that there are "airspace" improvements regarding [WebView](/uwp/api/windows.ui.xaml.controls.webview) render behavior that may obviate the need for a brush that draws HTML content.

## -examples

## -see-also
[Brush](brush.md), [ImageBrush](imagebrush.md), [WebViewBrush](/uwp/api/windows.ui.xaml.controls.webviewbrush), [Use brushes](/windows/uwp/graphics/using-brushes)
