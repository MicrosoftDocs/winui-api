---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetObject(System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetObject(System.Object)

<!--
public object GetObject (object xamlDirectObject);
-->

## -description

Gets (and creates if necessary) the instance as its full XAML type of the specified [IXamlDirectObject](ixamldirectobject.md). 

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirectObject](ixamldirectobject.md).

## -returns

Returns the instance of the full XAML type (typically, but not always, a [DependencyObject](/uwp/api/windows.ui.xaml.dependencyobject)).

## -remarks

Use this method to convert from a [XamlDirect](xamldirect.md) instance to its full XAML type. This results in the creation of a full object and hence the performance benefits of staying within the [XamlDirect](xamldirect.md) APIs will be lost for that specific [IXamlDirectObject](ixamldirectobject.md) instance.

## -see-also

[IXamlDirect.GetXamlDirectObject](ixamldirect_getxamldirectobject_197339041.md)

## -examples

The following example shows how to convert an [IXamlDirectObject](ixamldirectobject.md) instance pointing to a [Border](/uwp/api/windows.ui.xaml.controls.border) element to its full XAML type.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
Border borderDO = (Border)xd.GetObject(border);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
Border^ borderDO = dynamic_cast<Border^>(xd->GetObject(border));
```
