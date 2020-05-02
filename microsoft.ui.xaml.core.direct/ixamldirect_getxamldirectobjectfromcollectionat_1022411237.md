---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetXamlDirectObjectFromCollectionAt(System.Object,System.UInt32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetXamlDirectObjectFromCollectionAt(System.Object,System.UInt32)

<!--
public object GetXamlDirectObjectFromCollectionAt (object xamlDirectObject, uint index);
-->

## -description

Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index from the specified [IXamlDirectObject](ixamldirectobject.md) collection.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param index

Refers to the index in the collection of the item to get.

## -returns

Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index of the collection.

## -remarks

## -see-also

## -examples

The following example shows how to access an [IXamlDirectObject](ixamldirectobject.md) item at the specified index of a collection.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject first = xd.GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ first = xd->GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```
