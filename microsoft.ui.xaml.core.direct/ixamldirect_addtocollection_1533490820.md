---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddToCollection(System.Object,System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddToCollection(System.Object,System.Object)

<!--
public void AddToCollection (object xamlDirectObject, object value);
-->

## -description

Adds a value to the specified [IXamlDirect](ixamldirect.md) collection.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirect](ixamldirect.md) collection.

### -param value

Refers to the [IXamlDirect](ixamldirect.md) value to add to the collection.

## -remarks

[IXamlDirect](ixamldirect.md) is the minimal handle to Xaml's internal object instances. Hence the collection and the value to add to the collection are both of type [IXamlDirect](ixamldirect.md).

## -see-also

[IXamlDirect.RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md), [IXamlDirect.RemoveFromCollectionAt(System.Object,System.UInt32)](ixamldirect_removefromcollectionat_1329285826.md), [IXamlDirect.InsertIntoCollectionAt(System.Object,System.UInt32,System.Object)](ixamldirect_insertintocollectionat_1006192088.md), [IXamlDirect.ClearCollection(System.Object)](ixamldirect_clearcollection_1351804274.md)

## -examples

