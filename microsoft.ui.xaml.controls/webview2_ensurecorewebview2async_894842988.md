---
-api-id: M:Microsoft.UI.Xaml.Controls.WebView2.EnsureCoreWebView2Async
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.WebView2.EnsureCoreWebView2Async

<!--
public Windows.Foundation.IAsyncAction EnsureCoreWebView2Async ();
-->

## -description

Explicitly trigger initialization of the control's CoreWebView2.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns

A Task that represents the background initialization process. When the task completes then the CoreWebView2 property will be available for use (non-null). Note that the [CoreWebView2Initialized](webview2_corewebview2initialized.md) event will be invoked before the task completes or on exceptions.

## -remarks

## -see-also

## -examples
