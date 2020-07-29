---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetCollectionCount(System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetCollectionCount(System.Object)

<!--
public uint GetCollectionCount (object xamlDirectObject);
-->

## -description

Returns the count of items in the specified [IXamlDirect](ixamldirect.md) collection.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirect](ixamldirect.md) collection.

## -returns

Count of items.

## -remarks

## -see-also

## -examples

The following example shows how to get the count of [Panel.Children](/uwp/api/windows.ui.xaml.controls.panel.children) through the [IXamlDirect](ixamldirect.md)'s instance.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirect relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirect childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

uint count = xd.GetCollectionCount(childrenCollection);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirect^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirect^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

UINT count = xd->GetCollectionCount(childrenCollection);
```
