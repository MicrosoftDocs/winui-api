---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.RemoveFromCollectionAt(System.Object,System.UInt32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.RemoveFromCollectionAt(System.Object,System.UInt32)

<!--
public void RemoveFromCollectionAt (object xamlDirectObject, uint index);
-->

## -description

Attempts to remove a value from the [IXamlDirect](ixamldirect.md) collection at the specified index.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirect](ixamldirect.md) collection.

### -param index

Refers to the index in the collection where the value must be removed.

## -remarks

## -see-also

[IXamlDirect.InsertIntoCollectionAt(System.Object,System.UInt32,System.Object)](ixamldirect_insertintocollectionat_1006192088.md), [IXamlDirect.AddToCollection(System.Object,System.Object)](ixamldirect_addtocollection_1533490820.md), [IXamlDirect.RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md), [IXamlDirect.ClearCollection(System.Object)](ixamldirect_clearcollection_1351804274.md)

## -examples

The following example shows how to remove a value from a specific index using [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirect relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirect childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

xd.RemoveFromCollectionAt(childrenCollection, 0);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirect^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirect^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

xd->RemoveFromCollectionAt(childrenCollection, 0);
```
