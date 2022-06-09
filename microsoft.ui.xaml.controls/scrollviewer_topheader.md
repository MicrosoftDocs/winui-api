---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewer.TopHeader
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement TopHeader { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.TopHeader

## -description
Gets or sets the content of the top header.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ScrollViewer>
  <ScrollViewer.TopHeader>headerObject</ScrollViewer.TopHeader>
</ScrollViewer>

```


## -xaml-values
<dl><dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the top header.

## -remarks
The [LeftHeader](scrollviewer_leftheader.md), TopHeader, and [TopLeftHeader](scrollviewer_topleftheader.md) properties can be set only when [ScrollViewer](scrollviewer.md) content's [HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md) is **Left** and [VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md) is **Top**.

The top header scrolls horizontally, but not vertically.

## -examples

## -see-also
