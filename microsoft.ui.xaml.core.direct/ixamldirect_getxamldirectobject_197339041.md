---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetXamlDirectObject(System.Object)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public XamlDirectObject IXamlDirect.GetXamlDirectObject(Object object)
-->

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetXamlDirectObject

## -description

Gets the instance as an [IXamlDirect](ixamldirect.md) for a given XAML type. 

## -parameters

### -param object

Refers to the specific XAML type (typically, but not always, a [DependencyObject](/uwp/api/windows.ui.xaml.dependencyobject).

## -returns

Returns the [IXamlDirect](ixamldirect.md) instance.

## -remarks

Use this method to convert from a full XAML type to its [XamlDirect](xamldirect.md) instance and then get the performance benefits of [XamlDirect](xamldirect.md) through property management, collection management and event handling functionalities exposed through the [XamlDirect](xamldirect.md) APIs.

## -see-also

[Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetObject(System.Object)](ixamldirect_getobject_961148834.md)

## -examples

The following example shows how to get the [IXamlDirect](ixamldirect.md) instance from a full XAML type.

```C#
XamlDirect xd = XamlDirect.GetDefault();

Border border = new Border();
IXamlDirect borderXDO = xd.GetXamlDirectObject(border);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

Border^ border = ref new Border();
IXamlDirect^ borderXDO = xd->GetXamlDirectObject(border);
```
