---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetEnumProperty(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)
-api-type: winrt method
---

<!-- Method syntax.
public uint XamlDirect.GetEnumProperty(IXamlDirectObject xamlDirectObject, XamlPropertyIndex propertyIndex)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetEnumProperty

## -description
Gets the value of an _Enum_ property for a specific [IXamlDirectObject](ixamldirectobject.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param xamlDirectObject
A reference to the specific [IXamlDirectObject](ixamldirectobject.md).

### -param propertyIndex
A reference to the _Enum_ property to get the value of from the list of supported properties in [XamlPropertyIndex](xamlpropertyindex.md) enum.

## -returns
_UInt32_ value of the specified property which can be cast to the desired _Enum_ type.

## -see-also
[XamlDirect.SetEnumProperty](xamldirect_setenumproperty_551741026.md)

