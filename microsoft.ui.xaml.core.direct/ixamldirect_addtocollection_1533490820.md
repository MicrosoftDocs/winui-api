---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddToCollection(System.Object,System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddToCollection(System.Object,System.Object)

<!--
public void AddToCollection (object xamlDirectObject, object value);
-->

## -description

Adds a value to the specified [IXamlDirectObject](ixamldirectobject.md) collection.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param value

Refers to the [IXamlDirectObject](ixamldirectobject.md) value to add to the collection.

## -remarks

[IXamlDirectObject](ixamldirectobject.md) is the minimal handle to Xaml's internal object instances. Hence the collection and the value to add to the collection are both of type [IXamlDirectObject](ixamldirectobject.md).

## -see-also

[IXamlDirect.RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md), [IXamlDirect.RemoveFromCollectionAt(System.Object,System.UInt32)](ixamldirect_removefromcollectionat_1329285826.md), [IXamlDirect.InsertIntoCollectionAt(System.Object,System.UInt32,System.Object)](ixamldirect_insertintocollectionat_1006192088.md), [IXamlDirect.ClearCollection(System.Object)](ixamldirect_clearcollection_1351804274.md)

## -examples

