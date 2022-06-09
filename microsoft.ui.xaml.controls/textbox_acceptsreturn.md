---
-api-id: P:Microsoft.UI.Xaml.Controls.TextBox.AcceptsReturn
-api-type: winrt property
---

<!-- Property syntax
public bool AcceptsReturn { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TextBox.AcceptsReturn

## -description
Gets or sets the value that determines whether the text box allows and displays the newline or return characters.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<TextBox AcceptsReturn="bool"/>
```


## -property-value
**true** if the text box allows newline characters; otherwise, **false**. The default is **false**.

## -remarks
If you change the AcceptsReturn property to **true**, text might be displayed differently due to text containing newline characters.

You can enable multi-line text in a [TextBox](textbox.md) control by using the AcceptsReturn property. Use the [ScrollViewer.HorizontalScrollBarVisibility](scrollviewer_horizontalscrollbarvisibility.md) or [ScrollViewer.VerticalScrollBarVisibility](scrollviewer_verticalscrollbarvisibilityproperty.md) attached properties to change scrollbar behavior. By default the scrollbars appear when the layout system calculates that the text exceeds the dimensions of the viewport for the [TextBox](textbox.md).

## -examples

## -see-also
[Display and edit text](/windows/apps/design/controls/text-controls), [ScrollViewer](scrollviewer.md)
