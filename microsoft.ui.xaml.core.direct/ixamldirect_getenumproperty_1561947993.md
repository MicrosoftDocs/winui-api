---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetEnumProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetEnumProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)

<!--
public uint GetEnumProperty (object xamlDirectObject, Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex propertyIndex);
-->

## -description

Gets the value of an _Enum_ property for a specific [IXamlDirect](ixamldirect.md).

## -parameters

### -param xamlDirectObject

A reference to the specific [IXamlDirect](ixamldirect.md).

### -param propertyIndex

A reference to the _Enum_ property on which to get the value from the list of supported properties in [XamlPropertyIndex](xamlpropertyindex.md) enum.

## -returns

_UInt32_ value of the specified property which can be cast to the desired _Enum_ type.

## -remarks

## -see-also

[IXamlDirect.SetEnumProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex,System.UInt32)](ixamldirect_setenumproperty_1389798377.md)

## -examples

