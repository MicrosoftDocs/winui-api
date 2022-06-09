---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsPresenter.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ItemsPresenter.Header

## -description
Gets or sets the content for the items header.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ItemsPresenter Header="headerString"/>
- or -
<ItemsPresenter>
  <ItemsPresenter.Header>headerObject</ItemsPresenter.Header>
</ItemsPresenter>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the items header. The default value is **null**.

## -remarks
You can set a data template for the Header by using the [HeaderTemplate](itemspresenter_headertemplate.md) property.

<!--Windows Blue bug 454690-->
> **Windows 8.1**
> Header alignment is handled differently in apps compiled for Windows 8 than in apps compiled for Windows 8.1.+ In an app compiled for Windows 8, the header is always left-aligned when the orientation of the items is **Horizontal**, or top-aligned when the orientation is **Vertical**. [VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md) and [HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md) values that you set are ignored.
+ In an app compiled for Windows 8.1, you can specify the header alignment. [VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md) and [HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md) values that you set are not ignored.


## -examples

## -see-also
