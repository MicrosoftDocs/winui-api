---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class GridViewItemPresenter : Windows.UI.Xaml.Controls.ContentPresenter, Windows.UI.Xaml.Controls.Primitives.IGridViewItemPresenter
-->

# Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter

## -description
Represents the visual elements of a [GridViewItem](../microsoft.ui.xaml.controls/gridviewitem.md). When developing for Windows 10, use [ListViewItemPresenter](listviewitempresenter.md) instead of GridViewItemPresenter in your item container style, both for [ListView](../microsoft.ui.xaml.controls/listview.md) and for [GridView](../microsoft.ui.xaml.controls/gridview.md). If you edit a copy of the default item container styles then you will get the correct type.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<GridViewItemPresenter .../>
```


## -remarks
The XAML usage shown is intended to be part of a XAML template or style for a [GridView](../microsoft.ui.xaml.controls/gridview.md) control (or derived type) and its items. For more info, see [GridView](../microsoft.ui.xaml.controls/gridview.md).

For a custom GridViewItemPresenter, use the name of your class as the string within the object element syntax for XAML. You'll probably have to map an **xmlns** definition with a prefix to refer to your class definition. For more info, see [XAML namespaces and namespace mapping](/windows/uwp/xaml-platform/xaml-namespaces-and-namespace-mapping).

## -examples

## -see-also
[ContentPresenter](../microsoft.ui.xaml.controls/contentpresenter.md)
