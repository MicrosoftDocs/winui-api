---
-api-id: M:Microsoft.UI.Xaml.Controls.WebView2.NavigateToString(System.String)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.WebView2.NavigateToString(System.String)

<!--
public void NavigateToString (string htmlContent);
-->

## -description

Initiates a navigation to a new HTML document.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param htmlContent

HTML source of the new document.

## -remarks

*htmlContent* cannot be larger than 2 MB (2 * 1024 * 1024 bytes) in total size. The origin of the new page is about:blank.

## -see-also

## -examples
