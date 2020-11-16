---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.RemoveFromCollection(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject,Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
---

<!-- Method syntax.
public bool XamlDirect.RemoveFromCollection(IXamlDirectObject xamlDirectObject, IXamlDirectObject value)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.RemoveFromCollection

## -description
Tries to remove a value from the specified [IXamlDirectObject](ixamldirectobject.md) collection.

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param value
Refers to the [IXamlDirectObject](ixamldirectobject.md) value to remove from the collection.

## -returns
**true** if value was present.
**false** if value was not present.

## -see-also

[XamlDirect.AddToCollection](xamldirect_addtocollection_851707875.md), [XamlDirect.InsertIntoCollectionAt](xamldirect_insertintocollectionat_2128865667.md), [XamlDirect.RemoveFromCollectionAt](xamldirect_removefromcollectionat_1024397129.md), [XamlDirect.ClearCollection](xamldirect_clearcollection_581345531.md)

## -examples
The following example shows how to remove a value from a collection using [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);

xd.RemoveFromCollection(childrenCollection, button); // Should return true
xd.RemoveFromCollection(childrenCollection, button); // Should return false
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);

xd->RemoveFromCollection(childrenCollection, button); // Should return true
xd->RemoveFromCollection(childrenCollection, button); // Should return false
```

