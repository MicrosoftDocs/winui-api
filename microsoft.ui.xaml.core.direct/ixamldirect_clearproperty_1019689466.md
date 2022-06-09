---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)

<!--
public void ClearProperty (object xamlDirectObject, Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex propertyIndex);
-->


## -description

Clears the value of the specified property on a given [IXamlDirect](ixamldirect.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters

### -param xamlDirectObject

A reference to the specific [IXamlDirect](ixamldirect.md).

### -param propertyIndex

A reference to the property to be cleared from the list of supported properties in [XamlPropertyIndex](xamlpropertyindex.md) enum.

## -remarks

## -see-also

## -examples

The following example shows how to clear the value of a [Border](/uwp/api/windows.ui.xaml.controls.border) element's [MinHeight](/uwp/api/windows.ui.xaml.frameworkelement.minheight) property through [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirect border = xd.CreateInstance(XamlTypeIndex.Border);
xd.ClearProperty(border, XamlPropertyIndex.FrameworkElement_MinHeight);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirect^ border = xd->CreateInstance(XamlTypeIndex::Border);
xd->ClearProperty(border, XamlPropertyIndex::FrameworkElement_MinHeight);
```
