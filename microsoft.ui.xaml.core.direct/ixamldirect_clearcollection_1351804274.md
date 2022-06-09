---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearCollection(System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.ClearCollection(System.Object)

<!--
public void ClearCollection (object xamlDirectObject);
-->

## -description

Removes all items from the specified [IXamlDirect](ixamldirect.md) collection.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirect](ixamldirect.md) collection.

## -remarks

## -see-also

[IXamlDirect.AddToCollection(System.Object,System.Object)](ixamldirect_addtocollection_1533490820.md), [IXamlDirect.RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md)

## -examples

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirect relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirect childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirect button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);

xd.ClearCollection(childrenCollection);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirect^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirect^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirect^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);

xd->ClearCollection(childrenCollection);
```
