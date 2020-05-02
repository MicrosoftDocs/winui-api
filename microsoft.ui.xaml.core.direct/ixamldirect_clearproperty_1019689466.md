---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)

<!--
public void ClearProperty (object xamlDirectObject, Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex propertyIndex);
-->


## -description

Clears the value of the specified property on a given [IXamlDirectObject](ixamldirectobject.md).

## -parameters

### -param xamlDirectObject

A reference to the specific [IXamlDirectObject](ixamldirectobject.md).

### -param propertyIndex

A reference to the property to be cleared from the list of supported properties in [XamlPropertyIndex](xamlpropertyindex.md) enum.

## -remarks

## -see-also

## -examples

The following example shows how to clear the value of a [Border](../windows.ui.xaml.controls/border.md) element's [MinHeight](../windows.ui.xaml/frameworkelement_minheight.md) property through [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
xd.ClearProperty(border, XamlPropertyIndex.FrameworkElement_MinHeight);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
xd->ClearProperty(border, XamlPropertyIndex::FrameworkElement_MinHeight);
```
