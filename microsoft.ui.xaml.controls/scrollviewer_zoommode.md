---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewer.ZoomMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ZoomMode ZoomMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.ZoomMode

## -description
Gets or sets a value that indicates whether zoom behavior in the [ScrollViewer](scrollviewer.md) content is enabled.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ScrollViewer ZoomMode="zoomModeMemberName" />
-or-
<object ScrollViewer.ZoomMode="zoomModeMemberName"/>
```


## -property-value
A value of the enumeration.

## -remarks
No default value is listed for this property. Controls that incorporate a [ScrollViewer](scrollviewer.md) in compositing often set a value for ZoomMode in the default template and starting visual states, and it is this templated value that you will typically start with. Controls with a [ScrollViewer](scrollviewer.md) as part of their composition typically use template binding such that setting the attached property at the level of the control will change the scroll behavior of the [ScrollViewer](scrollviewer.md) part within the control. Otherwise, it may be necessary to replace the template in order to change the scroll behavior of a [ScrollViewer](scrollviewer.md) part.

## -examples

## -see-also
