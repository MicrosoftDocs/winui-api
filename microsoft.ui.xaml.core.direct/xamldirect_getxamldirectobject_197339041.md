---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObject(System.Object)
-api-type: winrt method
---

<!-- Method syntax.
public IXamlDirectObject XamlDirect.GetXamlDirectObject(Object object)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObject

## -description
Gets the instance as an [IXamlDirectObject](ixamldirectobject.md) for a given XAML type. 

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param object
Refers to the specific XAML type (typically, but not always, a [DependencyObject](../microsoft.ui.xaml/dependencyobject.md)).

## -returns
Returns the [IXamlDirectObject](ixamldirectobject.md) instance.

## -remarks
Use this method to convert from a full XAML type to its [XamlDirect](xamldirect.md) instance and then get the performance benefits of [XamlDirect](xamldirect.md) through property management, collection management and event handling functionalities exposed through the [XamlDirect](xamldirect.md) APIs.

## -see-also
[XamlDirect.GetObject](xamldirect_getobject_1266528811.md)

## -examples
The following example shows how to get the [IXamlDirectObject](ixamldirectobject.md) instance from a full XAML type.

```C#
XamlDirect xd = XamlDirect.GetDefault();

Border border = new Border();
IXamlDirectObject borderXDO = xd.GetXamlDirectObject(border);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

Border^ border = ref new Border();
IXamlDirectObject^ borderXDO = xd->GetXamlDirectObject(border);
```

