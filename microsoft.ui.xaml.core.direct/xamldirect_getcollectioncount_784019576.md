---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetCollectionCount(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
---

<!-- Method syntax.
public uint XamlDirect.GetCollectionCount(IXamlDirectObject xamlDirectObject)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetCollectionCount

## -description
Returns the count of items in the specified [IXamlDirectObject](ixamldirectobject.md) collection.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

## -returns
Count of items.

## -examples
The following example shows how to get the count of [Panel.Children](../microsoft.ui.xaml.controls/panel_children.md) through the [IXamlDirectObject](ixamldirectobject.md)'s instance.

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
