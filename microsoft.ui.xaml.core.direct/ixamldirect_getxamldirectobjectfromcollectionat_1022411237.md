---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetXamlDirectObjectFromCollectionAt(System.Object,System.UInt32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetXamlDirectObjectFromCollectionAt(System.Object,System.UInt32)

<!--
public object GetXamlDirectObjectFromCollectionAt (object xamlDirectObject, uint index);
-->

## -description

Returns the [IXamlDirect](ixamldirect.md) item at the specified index from the specified [IXamlDirect](ixamldirect.md) collection.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirect](ixamldirect.md) collection.

### -param index

Refers to the index in the collection of the item to get.

## -returns

Returns the [IXamlDirect](ixamldirect.md) item at the specified index of the collection.

## -remarks

## -see-also

## -examples

The following example shows how to access an [IXamlDirect](ixamldirect.md) item at the specified index of a collection.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirect relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirect childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirect first = xd.GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirect^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirect^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirect^ first = xd->GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```
