---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.InsertIntoCollectionAt(System.Object,System.UInt32,System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.InsertIntoCollectionAt(System.Object,System.UInt32,System.Object)

<!--
public void InsertIntoCollectionAt (object xamlDirectObject, uint index, object value);
-->

## -description

Inserts a value into the specified [IXamlDirect](ixamldirect.md) collection at the specified index.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirect](ixamldirect.md) collection.

### -param index

Refers to the index in the collection where the specified value must be inserted.

### -param value

Refers to the [IXamlDirect](ixamldirect.md) value to add to the collection.

## -remarks

## -see-also

[IXamlDirect.RemoveFromCollectionAt(System.Object,System.UInt32)](ixamldirect_removefromcollectionat_1329285826.md), [IXamlDirect.AddToCollection(System.Object,System.Object)](ixamldirect_addtocollection_1533490820.md), [IXamlDirect.RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md), [IXamlDirect.ClearCollection(System.Object)](ixamldirect_clearcollection_1351804274.md)

## -examples

The following example shows how to insert a value into a collection at a specific index using [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirect relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirect childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirect button = xd.CreateInstance(XamlTypeIndex.Button);
xd.InsertIntoCollectionAt(childrenCollection, 0, button);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirect^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirect^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirect^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->InsertIntoCollectionAt(childrenCollection, 0, button);
```
