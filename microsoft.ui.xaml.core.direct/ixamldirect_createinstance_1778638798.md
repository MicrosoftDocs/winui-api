---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.CreateInstance(Microsoft.UI.Xaml.Core.Direct.XamlTypeIndex)
-api-type: winrt method
---

<!-- Method syntax.
public XamlDirectObject IXamlDirect.CreateInstance(XamlTypeIndex typeIndex)
-->

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.CreateInstance

## -description

Creates an [IXamlDirect](ixamldirect.md) instance of the type specified by the [XamlTypeIndex](xamltypeindex.md) parameter.

## -parameters

### -param typeIndex

Refers to the specific XAML type from the set of supported types listed in the [XamlTypeIndex](xamltypeindex.md) enum.

## -returns

Returns the [IXamlDirect](ixamldirect.md) instance.

## -remarks

## -see-also

[XamlDirect](xamldirect.md)

## -examples

The following example shows how to create an [IXamlDirect](ixamldirect.md) instance for a [Border](/uwp/api/windows.ui.xaml.controls.border) element.

```C#
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirect border = xd.CreateInstance(XamlTypeIndex.Border);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirect^ border = xd->CreateInstance(XamlTypeIndex::Border);
```
