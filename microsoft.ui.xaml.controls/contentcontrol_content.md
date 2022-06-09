---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentControl.Content
-api-type: winrt property
---

<!-- Property syntax
public object Content { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentControl.Content

## -description
Gets or sets the content of a [ContentControl](contentcontrol.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<contentControl>
    singleObject
</contentControl>
-or-
<contentControl>stringContent</contentControl>
- or -
<contentControl Content="stringContent"/>
```


## -xaml-values
<dl><dt>contentControl</dt><dd>contentControlA ContentControl object element, or an object element for a class that derives from ContentControl.</dd>
<dt>singleObject</dt><dd>singleObjectA single object element that declares the content. Typically this is a class that can support further content as child elements, such as a Panel class.</dd>
<dt>stringContent</dt><dd>stringContentA string that is the Content of the ContentControl.</dd>
</dl>
## -property-value
An object that contains the control's content. The default is **null**.

## -remarks

## -examples

## -see-also
