---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObjectFromCollectionAt(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax.
public IXamlDirectObject XamlDirect.GetXamlDirectObjectFromCollectionAt(IXamlDirectObject xamlDirectObject, UInt32 index)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObjectFromCollectionAt

## -description
Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index from the specified [IXamlDirectObject](ixamldirectobject.md) collection.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param index
Refers to the index in the collection of the item to get.

## -returns
Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index of the collection.

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
