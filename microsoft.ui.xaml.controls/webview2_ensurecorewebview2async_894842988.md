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

## -returns

A Task that represents the background initialization process. When the task completes then the CoreWebView2 property will be available for use (non-null). Note that the [CoreWebView2Initialized](webview2_corewebview2initialized.md) event will be invoked before the task completes or on exceptions.

## -remarks

## -see-also

## -examples
