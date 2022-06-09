---
-api-id: T:Microsoft.UI.Xaml.Controls.HubSectionCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HubSectionCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Controls.HubSection>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Controls.HubSection>
-->

# Microsoft.UI.Xaml.Controls.HubSectionCollection

## -description
Represents an ordered collection of [HubSection](hubsection.md) objects.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Hub>
  oneOrMoreChildren
</Hub>
```


## -remarks
<!--Hub.Sections doesn't seem to be using this type yet, so this needs to be confirmed.-->
A HubSectionCollection is the type of object that you get from the [Sections](hub_sections.md) property of a [Hub](hub.md). All the properties that use a HubSectionCollection in the Windows Runtime  API are read-only properties, where the property is initialized with zero items when an object is first instantiated. But you can then add, remove or query items in the collection at run time, using the HubSectionCollection properties and methods.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A HubSectionCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [HubSection](hubsection.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[Control](control.md), [Hub](hub.md), [HubSection](hubsection.md), [HubSectionHeaderClickEventArgs](hubsectionheaderclickeventargs.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IVector(HubSection)](/uwp/api/windows.foundation.collections.ivector`1), [IIterable(HubSection)](/uwp/api/windows.foundation.collections.iiterable`1)
