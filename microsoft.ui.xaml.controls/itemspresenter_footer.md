---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsPresenter.Footer
-api-type: winrt property
---

<!-- Property syntax
public object Footer { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ItemsPresenter.Footer

## -description
Gets or sets the content for the items footer.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ItemsPresenter Footer="footerString"/>
- or -
<ItemsPresenter>
  <ItemsPresenter.Footer>footerObject</ItemsPresenter.Footer>
</ItemsPresenter>

```


## -xaml-values
<dl><dt>footerString</dt><dd>footerStringA text string that serves as footer content.</dd>
<dt>footerObject</dt><dd>footerObjectAn single object element that serves as footer content. Use discretion when using objects as footer content; not all objects are suitable for use within the limited presentation surface that appears for footers.</dd>
</dl>
## -property-value
The content of the items footer. The default is **null**.

## -remarks
You can set a data template for the Footer by using the [FooterTemplate](itemspresenter_footertemplate.md) property.

## -examples

## -see-also
[FooterTemplate](itemspresenter_footertemplate.md), [Header](itemspresenter_header.md), [HeaderTemplate](itemspresenter_headertemplate.md)
