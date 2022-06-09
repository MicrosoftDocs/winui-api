---
-api-id: P:Microsoft.UI.Xaml.Controls.ListViewBase.Footer
-api-type: winrt property
---

<!-- Property syntax
public object Footer { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.Footer

## -description
Gets or sets the content for the list footer.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<listViewBase Footer="footerString"/>
- or -
<listViewBase>
  <listViewBase.Footer>
    footerObject
  </listViewBase.Footer>
</listViewBase>

```


## -xaml-values
<dl><dt>footerString</dt><dd>footerStringA text string that serves as footer content.</dd>
<dt>footerObject</dt><dd>footerObjectAn single object element that serves as footer content. Use discretion when using objects as footer content; not all objects are suitable for use within the limited presentation surface that appears for footers.</dd>
</dl>
## -property-value
The content of the list footer. The default is **null**.

## -remarks
By default, the footer is shown at the bottom for a [ListView](listview.md), and on the right for a [GridView](gridview.md). If the [FlowDirection](../microsoft.ui.xaml/frameworkelement_flowdirection.md) property is set to [RightToLeft](../microsoft.ui.xaml/flowdirection.md), the footer is shown on the left for a [GridView](gridview.md).

You can use a data template for the footer by setting the [FooterTemplate](itemspresenter_footertemplate.md) property.

## -examples

## -see-also
[FooterTemplate](itemspresenter_footertemplate.md), [Header](listviewbase_header.md)
