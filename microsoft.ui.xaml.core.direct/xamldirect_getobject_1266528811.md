---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetObject(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
---

<!-- Method syntax.
public object XamlDirect.GetObject(IXamlDirectObject xamlDirectObject)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetObject

## -description
Gets (and creates if necessary) the instance as its full XAML type of the specified [IXamlDirectObject](ixamldirectobject.md). 

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md).

## -returns
Returns the instance of the full XAML type (typically, but not always, a [DependencyObject](../microsoft.ui.xaml/dependencyobject.md)).

## -remarks
Use this method to convert from a [XamlDirect](xamldirect.md) instance to its full XAML type. This results in the creation of a full object and hence the performance benefits of staying within the [XamlDirect](xamldirect.md) APIs will be lost for that specific [IXamlDirectObject](ixamldirectobject.md) instance.

## -see-also
[XamlDirect.GetXamlDirectObject](xamldirect_getxamldirectobject_197339041.md)

## -examples
The following example shows how to convert an [IXamlDirectObject](ixamldirectobject.md) instance pointing to a [Border](../microsoft.ui.xaml.controls/border.md) element to its full XAML type.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
Border borderDO = (Border)xd.GetObject(border);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
Border^ borderDO = dynamic_cast<Border^>(xd->GetObject(border));
```

