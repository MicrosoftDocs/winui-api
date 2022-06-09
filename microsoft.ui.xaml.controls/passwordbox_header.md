---
-api-id: P:Microsoft.UI.Xaml.Controls.PasswordBox.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.PasswordBox.Header

## -description
Gets or sets the content for the control's header.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<PasswordBox Header="headerString"/>
- or -
<PasswordBox>
  <PasswordBox.Header>headerObject</PasswordBox.Header>
</PasswordBox>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectA single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the control's header. The default is **null**.

## -remarks
You can set a data template for the Header value by using the [HeaderTemplate](passwordbox_headertemplate.md) property.

## -examples

## -see-also
[Password](passwordbox_password.md), [HeaderTemplate](passwordbox_headertemplate.md), [PasswordBox styles and templates](/windows/apps/design/style/xaml-styles)
