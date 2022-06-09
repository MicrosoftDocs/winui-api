---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.AddToCollection(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject,Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlDirect.AddToCollection(IXamlDirectObject xamlDirectObject, IXamlDirectObject value)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.AddToCollection

## -description
Adds a value to the specified [IXamlDirectObject](ixamldirectobject.md) collection.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param value
Refers to the [IXamlDirectObject](ixamldirectobject.md) value to add to the collection.

## -remarks
[IXamlDirectObject](ixamldirectobject.md) is the minimal handle to Xaml's internal object instances. Hence the collection and the value to add to the collection are both of type [IXamlDirectObject](ixamldirectobject.md).

## -see-also

[XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_297783714.md), [XamlDirect.InsertIntoCollectionAt](xamldirect_insertintocollectionat_2128865667.md), [XamlDirect.RemoveFromCollectionAt](xamldirect_removefromcollectionat_1024397129.md), [XamlDirect.ClearCollection](xamldirect_clearcollection_581345531.md)

## -examples
The following example shows how to add a value to a collection using [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);
```
