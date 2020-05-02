---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.CreateInstance(Microsoft.UI.Xaml.Core.Direct.XamlTypeIndex)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public XamlDirectObject IXamlDirect.CreateInstance(XamlTypeIndex typeIndex)
-->

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.CreateInstance

## -description

Creates an [IXamlDirectObject](ixamldirectobject.md) instance of the type specified by the [XamlTypeIndex](xamltypeindex.md) parameter.

## -parameters

### -param typeIndex

Refers to the specific XAML type from the set of supported types listed in the [XamlTypeIndex](xamltypeindex.md) enum.

## -returns

Returns the [IXamlDirectObject](ixamldirectobject.md) instance.

## -remarks

## -see-also

[XamlDirect](xamldirect.md)

## -examples

The following example shows how to create an [IXamlDirectObject](ixamldirectobject.md) instance for a [Border](../windows.ui.xaml.controls/border.md) element. 

```C#
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
```
