---
-api-id: P:Microsoft.UI.Xaml.Controls.SplitView.IsPaneOpen
-api-type: winrt property
---

<!-- Property syntax
public bool IsPaneOpen { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.SplitView.IsPaneOpen

## -description
Gets or sets a value that specifies whether the [SplitView](splitview.md) pane is expanded to its full width.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml

      <SplitView IsPaneOpen="bool" .../>
    
```


## -property-value
**true** if the pane is expanded to its full width; otherwise, **false**. The default is **true**.

## -remarks

The effects of this property are influenced by the value of the [DisplayMode](splitview_displaymode.md) property.

| DisplayMode | Effect |
|---|---|
| **Inline** | IsPaneOpen is **true**. |
| **Overlay** | When IsPaneOpen is **false**, the pane is hidden. |
| **Compact** | When IsPaneOpen is **false**, the pane is shown in its compact size (see [CompactPaneLength](splitview_compactpanelength.md)). |

## -examples

## -see-also
