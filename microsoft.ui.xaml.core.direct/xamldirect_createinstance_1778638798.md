---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.CreateInstance(Microsoft.UI.Xaml.Core.Direct.XamlTypeIndex)
-api-type: winrt method
---

<!-- Method syntax.
public IXamlDirectObject XamlDirect.CreateInstance(XamlTypeIndex typeIndex)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.CreateInstance

## -description
Creates an [IXamlDirectObject](ixamldirectobject.md) instance of the type specified by the [XamlTypeIndex](xamltypeindex.md) parameter.

## -parameters
### -param typeIndex
Refers to the specific XAML type from the set of supported types listed in the [XamlTypeIndex](xamltypeindex.md) enum.

## -returns
Returns the [IXamlDirectObject](ixamldirectobject.md) instance.

## -see-also
[XamlDirect](xamldirect.md), [XamlDirect.GetDefault](xamldirect_getdefault_846721868.md)

## -examples
The following example shows how to create an [IXamlDirectObject](ixamldirectobject.md) instance for a [Border](../microsoft.ui.xaml.controls/border.md) element. 

```C#
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
```
