---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBar.IsSticky
-api-type: winrt property
---

<!-- Property syntax
public bool IsSticky { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBar.IsSticky

## -description
Gets or sets a value that indicates whether the [AppBar](appbar.md) does not close on light dismiss.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<AppBar IsSticky="bool" .../>
```


## -property-value
**true** if the [AppBar](appbar.md) does not close on light dismiss. **false** if the [AppBar](appbar.md) is hidden on light dismiss.

## -remarks
By default, app bars are dismissed when the user interacts with your app anywhere outside of the app bar. This is called *light dismiss*. To keep commands visible, you can change the dismissal mode by setting the IsSticky property to **true**. When an app bar is *sticky*, it's dismissed only when the user right-clicks, presses Windows+Z, or swipes from the top or bottom edge of the screen.

## -examples


[!code-xaml[IsStickyXAML](../microsoft.ui.xaml.controls/code/AppBarSample/CS/SnippetsPage.xaml#SnippetIsStickyXAML)]

## -see-also
[Quickstart: Adding app bars](/previous-versions/windows/apps/hh781232(v=win.10))
