---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearCollection(System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearCollection(System.Object)

<!--
public void ClearCollection (object xamlDirectObject);
-->

## -description

Removes all items from the specified [IXamlDirectObject](ixamldirectobject.md) collection.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

## -remarks

## -see-also

[IXamlDirect.AddToCollection(System.Object,System.Object)](ixamldirect_addtocollection_1533490820.md), [IXamlDirect.RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md)

## -examples

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);

xd.ClearCollection(childrenCollection);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);

xd->ClearCollection(childrenCollection);
```
