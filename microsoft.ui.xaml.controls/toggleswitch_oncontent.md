---
-api-id: P:Microsoft.UI.Xaml.Controls.ToggleSwitch.OnContent
-api-type: winrt property
---

<!-- Property syntax
public object OnContent { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ToggleSwitch.OnContent

## -description
Provides the object content that should be displayed using the [OnContentTemplate](toggleswitch_oncontenttemplate.md) when this [ToggleSwitch](toggleswitch.md) has state of "On".

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ToggleSwitch OnContent="stringContent"/>
- or -
<ToggleSwitch>
  <ToggleSwitch.OnContent>
    singleContentElement
  </ToggleSwitch.OnContent>
</ToggleSwitch>
```


## -xaml-values
<dl><dt>stringContent</dt><dd>stringContentA string that declares the On state content. Can also be a reference to a resource, which might be a string or could also be a composited object.</dd>
<dt>singleContentElement</dt><dd>singleContentElementA single object element for a class that derives from UIElement and can be handled by the default ContentPresenter.</dd>
</dl>
## -property-value
The object content. In some cases this is a string, in other cases it is a single element that provides a root for further composition content. Probably the most common "set" usage is to place a binding here.

## -remarks

## -examples

## -see-also
