---
-api-id: P:Microsoft.UI.Xaml.UIElement.Lights
-api-type: winrt property
---

<!-- Property syntax.
public IVector<XamlLight> Lights { get; }
-->

# Microsoft.UI.Xaml.UIElement.Lights

## -description
Gets the collection of [XamlLight](../microsoft.ui.xaml.media/xamllight.md) objects attached to this element.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<uielement>
  <uielement.Lights>
    oneOrMoreXamlLights
  </uielement.Lights>
</uielement>
```

> [!Important]
> Setting UIElement.Lights in markup as shown in the above example is only supported for apps with a Minimum Version equal to the Windows 10 Creators Update or later. For apps that target earlier minimum versions, lights must be created in code-behind.

## -xaml-values
<dl><dt>oneOrMoreXamlLights</dt><dd>One or more object elements of types that are derived from the XamlLight base type. Typically there is only one of each type of light included in the collection.</dd>
</dl>

## -property-value
The collection of [XamlLight](../microsoft.ui.xaml.media/xamllight.md) elements that apply to a [UIElement](uielement.md).

## -remarks

## -see-also
[XamlLight](../microsoft.ui.xaml.media/xamllight.md)

## -examples

