---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetCollectionCount(System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.GetCollectionCount(System.Object)

<!--
public uint GetCollectionCount (object xamlDirectObject);
-->

## -description

Returns the count of items in the specified [IXamlDirectObject](ixamldirectobject.md) collection.

## -parameters

### -param xamlDirectObject

Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

## -returns

Count of items.

## -remarks

## -see-also

## -examples

The following example shows how to get the count of [Panel.Children](../windows.ui.xaml.controls/panel_children.md) through the [IXamlDirectObject](ixamldirectobject.md)'s instance.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

uint count = xd.GetCollectionCount(childrenCollection);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

UINT count = xd->GetCollectionCount(childrenCollection);
```
