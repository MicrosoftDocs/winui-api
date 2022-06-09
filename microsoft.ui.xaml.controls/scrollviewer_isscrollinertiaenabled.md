---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewer.IsScrollInertiaEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsScrollInertiaEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.IsScrollInertiaEnabled

## -description
Gets or sets a value that indicates whether scroll actions should include inertia in their behavior and value.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ScrollViewer IsScrollInertiaEnabled="bool" />
-or-
<object ScrollViewer.IsScrollInertiaEnabled="bool"/>
```


## -property-value
**true** if scroll actions should include inertia in their behavior and value; otherwise, **false**.

## -remarks
For XAML usage, IsScrollInertiaEnabled can either be an attribute on an explicit [ScrollViewer](scrollviewer.md) element, or a **ScrollViewer.IsScrollInertiaEnabled** attached property usage on an element that is a child of a control that supports scrollview implicitly in its template.
<!--May not work because there is no apparent templatebinding linkage in most of the generic templates.-->

## -examples

## -see-also

[Scroll viewer controls](/windows/apps/design/controls/scroll-controls), [Guidelines for panning](/windows/apps/design/input/guidelines-for-panning)
