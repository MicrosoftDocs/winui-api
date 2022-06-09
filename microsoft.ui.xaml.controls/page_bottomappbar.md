---
-api-id: P:Microsoft.UI.Xaml.Controls.Page.BottomAppBar
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.AppBar BottomAppBar { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Page.BottomAppBar

## -description
Gets a reference to an [AppBar](appbar.md) displayed at the bottom of the page, if any.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Page ...>
  <Page.BottomAppBar>
    <AppBar .../>
  </Page.BottomAppBar>
</Page>
```


## -property-value
A reference to an [AppBar](appbar.md) displayed at the bottom of the page, or **null**.

## -remarks
In XAML, make sure you specify the `Page.BottomAppBar` property element in the same area as other property elements that may already be defined, like `Page.TopAppBar` or `Page.Resources`. The XAML language enforces that you can't mix the property elements between the XAML content that is setting [Content](usercontrol_content.md), such as the typical root [Grid](grid.md) element. For more info on XAML syntax, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

## -examples
For example code that adds an [AppBar](appbar.md) to a page, see [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10)) or [How to share an app bar across pages](/previous-versions/windows/apps/jj150604(v=win.10)). For a complete sample that uses many of the [Page](page.md) and [Frame](frame.md) features together, see [XAML Navigation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlNavigation).

## -see-also
[AppBar](appbar.md), [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10))
