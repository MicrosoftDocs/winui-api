---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.CanVerticallyScroll
-api-type: winrt property
---

<!-- Property syntax
public bool CanVerticallyScroll { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.CanVerticallyScroll

## -description
Gets or sets a value that determines how the [OrientedVirtualizingPanel](orientedvirtualizingpanel.md) measures space for child elements for possible scrolling in the vertical dimension.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
**true** to support a potentially infinite vertical layout dimension. **false** to restrict to available size.

## -remarks
> [!NOTE]
> This property is not intended to be set inXAML. You can set the panel's **Orientation** property in XAML and optionally change the [ScrollViewer.HorizontalScrollBarVisibility](../microsoft.ui.xaml.controls/scrollviewer_horizontalscrollbarvisibility.md) or [ScrollViewer.VerticalScrollBarVisibility](../microsoft.ui.xaml.controls/scrollviewer_verticalscrollbarvisibility.md) to change how scrolling works. This property can be changed in code. In some cases you will need to use [VisualTreeHelper](../microsoft.ui.xaml.media/visualtreehelper.md) to access the panel.

## -examples

## -see-also
