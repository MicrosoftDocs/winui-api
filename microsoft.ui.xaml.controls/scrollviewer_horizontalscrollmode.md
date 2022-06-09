---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewer.HorizontalScrollMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ScrollMode HorizontalScrollMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.HorizontalScrollMode

## -description
Gets or sets a value that determines how manipulation input influences scrolling behavior on the horizontal axis.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ScrollViewer HorizontalScrollMode="scrollModeMemberName" />
-or-
<object ScrollViewer.HorizontalScrollMode="scrollModeMemberName"/>
```


## -property-value
A value of the enumeration. The typical default (as set through the default template, not class initialization) is **Enabled**.

## -remarks
Scrolling behavior can also be set through a `ScrollViewer.HorizontalScrollMode` XAML attached property usage, or by calling [SetHorizontalScrollMode](scrollviewer_sethorizontalscrollmode_463563719.md). This is for cases where the [ScrollViewer](scrollviewer.md) is implicit, such as when the [ScrollViewer](scrollviewer.md) exists in the default template for a [GridView](gridview.md), and you want to be able to influence the scrolling behavior without accessing template parts. Controls with a [ScrollViewer](scrollviewer.md) as part of their composition typically use template binding such that setting the attached property at the level of the control will change the scroll behavior of the [ScrollViewer](scrollviewer.md) part within the control. Otherwise, it may be necessary to replace the template in order to change the scroll behavior of a [ScrollViewer](scrollviewer.md) part.

## -examples

## -see-also

[Scroll viewer controls](/windows/apps/design/controls/scroll-controls), [Guidelines for panning](/windows/apps/design/input/guidelines-for-panning)
