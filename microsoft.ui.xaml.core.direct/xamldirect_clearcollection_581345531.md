---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.ClearCollection(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlDirect.ClearCollection(IXamlDirectObject xamlDirectObject)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.ClearCollection

## -description
Removes all items from the specified [IXamlDirectObject](ixamldirectobject.md) collection.

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

## -see-also

[XamlDirect.AddToCollection](xamldirect_addtocollection_851707875.md), [XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_297783714.md)

## -examples
The following example shows how to add to use the ClearCollection method to clear a collection pointed to by the specified [IXamlDirectObject](ixamldirectobject.md).

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
