---
-api-id: P:Microsoft.UI.Xaml.Window.Title
-api-type: winrt property
---

# Microsoft.UI.Xaml.Window.Title

<!--
public string Title { get; set; }
-->

## -description

Gets or sets a string used for the window title.

## -property-value

The string used for the window title.

## -remarks

In a UWP app, this property is a wrapper for [ApplicationView.Title](/uwp/api/windows.ui.viewmanagement.applicationview.title). In a Desktop app this is a wrapper for [SetWindowText](/windows/win32/api/winuser/nf-winuser-setwindowtextw).

In addition to the title bar, this string is used in other system UI such as the application switcher (Alt-Tab).

If [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) is set, this value is not displayed by the title bar.

## -examples

The following example shows a MainWindow.xaml file that specifies a `Title`.

```xaml
<Window 
    x:Class="MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Main Window">
...    
</Window>
```

## -see-also

[SetTitleBar(Microsoft.UI.Xaml.UIElement)](window_settitlebar_1494775390.md)
