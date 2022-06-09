---
-api-id: P:Microsoft.UI.Xaml.Controls.Slider.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Slider.Header

## -description
Gets or sets the content for the control's header.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Slider Header="headerString"/>
- or -
<Slider>
  <Slider.Header>headerObject</Slider.Header>
</Slider>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the control's header. The default is **null**.

## -remarks
You can set a data template for the Header by using the [HeaderTemplate](slider_headertemplate.md) property.

## -examples

## -see-also
[HeaderTemplate](slider_headertemplate.md)
