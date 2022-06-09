---
-api-id: P:Microsoft.UI.Xaml.Controls.Pivot.LeftHeader
-api-type: winrt property
---

<!-- Property syntax
public object LeftHeader { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Pivot.LeftHeader

## -description
Gets or sets the content for the header on the control's left side.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Pivot LeftHeader="headerString"/>
- or -
<Pivot>
  <Pivot.LeftHeader>headerObject</Pivot.LeftHeader>
</Pivot>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectA single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the header on the control's left side. The default is **null**.

## -remarks
You can set a data template for the LeftHeader value by using the [LeftHeaderTemplate](pivot_leftheadertemplate.md) property.

## -examples

## -see-also
[RightHeader](pivot_rightheader.md), [LeftHeaderTemplate](pivot_leftheadertemplate.md)
