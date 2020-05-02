---
-api-id: N:Microsoft.UI.Xaml.Core.Direct
-api-type: winrt namespace
ms.custom: RS5
---

<!-- Namespace syntax.
namespace Microsoft.UI.Xaml.Core.Direct 
-->

# Microsoft.UI.Xaml.Core.Direct

## -description

Provides a way for middleware authors to access low-level, high-performance XAML APIs and achieve better CPU and working set performance.

## -remarks

This namespace requires the **Microsoft.UI.Xaml.Core.Direct*- NuGet package, a part of the [Microsoft Windows UI Library](https://aka.ms/winui-docs).

[XamlDirect](xamldirect.md) is **purpose built for middleware*- that predominantly use imperative APIs to create UI instead of markup. With [XamlDirect](xamldirect.md) APIs, you can achieve performance parity with the XAML parser even when creating UI imperatively in code.

[XamlDirect](xamldirect.md) APIs can be used side-by-side with traditional APIs and take advantage of the pay for play performance improvements.  

Not all Xaml APIs are available with [XamlDirect](xamldirect.md). The [XamlTypeIndex enum](xamltypeindex.md) lists all supported types, the [XamlPropertyIndex enum](xamlpropertyindex.md) lists all supported properties, and the [XamlEventIndex enum](xamleventindex.md) lists all supported events.

### Supported functions

You can perform the following functions using XamlDirect APIs:

- Create an instance of an internal Xaml object for a regular Xaml type, like [Button](../windows.ui.xaml.controls/button.md), using [Microsoft.UI.Xaml.Core.Direct.IXamlDirect.CreateInstance](ixamldirect_createinstance_1778638798.md).
- Set property values using one of the appropriate variants of the XamlDirect.Set-Property method based on the type of the property. For example, use [SetColorProperty(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex,Windows.UI.Color)](ixamldirect_setcolorproperty_2039300524.md) to access the [SolidColorBrush.Color](/uwp/api/windows.ui.xaml.media.solidcolorbrush.color) property. Similarly use Get-Property methods to access specific properties.
- Add an item to a collection, like [Panel.Children](/uwp/api/windows.ui.xaml.controls.panel.children), using [AddToCollection(System.Object,System.Object)](ixamldirect_addtocollection_1533490820.md) and remove items from collections using [RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md) or [RemoveFromCollectionAt(System.Object,System.UInt32)](ixamldirect_removefromcollectionat_1329285826.md). XamlDirect supports a variety of such collection operations including [GetCollectionCount(System.Object)](ixamldirect_getcollectioncount_1552905727.md), [ClearCollection(System.Object)](ixamldirect_clearcollection_1351804274.md), [InsertIntoCollectionAt(System.Object,System.UInt32,System.Object)](ixamldirect_insertintocollectionat_1006192088.md), [RemoveFromCollectionAt(System.Object,System.UInt32)](ixamldirect_removefromcollectionat_1329285826.md), and [GetXamlDirectObjectFromCollectionAt(System.Object,System.UInt32)](ixamldirect_getxamldirectobjectfromcollectionat_1022411237.md).
- Add an event handler, like [Button.Click](../windows.ui.xaml.controls/button_click.md) using [AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)](ixamldirect_addeventhandler_800589073.md) and similarly remove event handlers using [Microsoft.UI.Xaml.Core.Direct.IXamlDirect.RemoveEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)](ixamldirect_removeeventhandler_1875707612.md).

All objects returned by [CreateInstance](ixamldirect_createinstance_1778638798.md) are of type [IXamlDirectObject](ixamldirectobject.md). All other APIs, such as the Set*Property APIs, take an [IXamlDirectObject](ixamldirectobject.md) as their first parameter.

To convert an [IXamlDirectObject](ixamldirectobject.md) to its full APINDEX, for example a [Button](../windows.ui.xaml.controls/button.md), use the [GetObject(System.Object)](ixamldirect_getobject_961148834.md) method. Similarly, you can use [GetXamlDirectObject](ixamldirect_getxamldirectobject_197339041.md) to convert from a full Object/DependencyObject to its XamlDirect equivalent instance.

## -see-also

[RemoveFromCollection(System.Object,System.Object)](ixamldirect_removefromcollection_2015158471.md), [RemoveFromCollectionAt(System.Object,System.UInt32)](ixamldirect_removefromcollectionat_1329285826.md), [InsertIntoCollectionAt(System.Object,System.UInt32,System.Object)](ixamldirect_insertintocollectionat_1006192088.md), [ClearCollection(System.Object)](ixamldirect_clearcollection_1351804274.md)

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
