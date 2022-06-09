---
-api-id: P:Microsoft.UI.Xaml.Controls.SplitView.CompactPaneLength
-api-type: winrt property
---

<!-- Property syntax
public double CompactPaneLength { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.SplitView.CompactPaneLength

## -description
Gets or sets the width of the [SplitView](splitview.md) pane in its compact display mode.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml

      <SplitView CompactPaneLength="double" .../>
    
```


## -property-value
The width of the pane in it's compact display mode. The default is 48 device-independent pixel (DIP) (defined by the **SplitViewCompactPaneThemeLength** resource).

## -remarks
This property specifies the width of the pane when [DisplayMode](splitview_displaymode.md) is [Compact](splitviewdisplaymode.md) and [IsPaneOpen](splitview_ispaneopen.md) is **false**.

## -examples

## -see-also
