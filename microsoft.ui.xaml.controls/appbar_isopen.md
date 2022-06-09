---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBar.IsOpen
-api-type: winrt property
---

<!-- Property syntax
public bool IsOpen { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBar.IsOpen

## -description
Gets or sets a value that indicates whether the [AppBar](appbar.md) is open.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<AppBar IsOpen="bool"/>
```


## -property-value
**true** if the app bar is open; otherwise, **false**.

## -remarks
How the app bar is displayed when it's open depends on the [ClosedDisplayMode](appbar_closeddisplaymode.md) property setting. For more info, see [App bar and command bar](/windows/uwp/controls-and-patterns/app-bars).

You can open and close the app bar programmatically by setting the IsOpen property. You can use the [Opening](appbar_opening.md), [Opened](appbar_opened.md), [Closing](appbar_closing.md), and [Closed](appbar_closed.md) events to respond to the app bar being opened or closed.

### Notes for previous versions

> **Windows 8**
> Binding to the IsOpen property doesn't have the expected results because the [PropertyChanged](../microsoft.ui.xaml.data/inotifypropertychanged.md) notification doesn't occur when the property is set.

## -examples


[!code-xaml[IsOpenXAML](../microsoft.ui.xaml.controls/code/AppBarSample/CS/SnippetsPage.xaml#SnippetIsOpenXAML)]

## -see-also
[Quickstart: Adding app bars](/previous-versions/windows/apps/hh781232(v=win.10))
