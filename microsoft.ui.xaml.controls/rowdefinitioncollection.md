---
-api-id: T:Microsoft.UI.Xaml.Controls.RowDefinitionCollection
-api-type: winrt class
---

<!-- Class syntax.
public class RowDefinitionCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Controls.RowDefinition>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Controls.RowDefinition>
-->

# Microsoft.UI.Xaml.Controls.RowDefinitionCollection

## -description
Provides access to an ordered, strongly typed collection of [RowDefinition](rowdefinition.md) objects.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<Grid ...>
  <Grid.RowDefinitions>
    oneOrMoreRowDefinitions
  </Grid.RowDefinitions>
</Grid>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A RowDefinitionCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<RowDefinition>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true)with a [RowDefinition](rowdefinition.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector`1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable`1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true), [RowDefinition](rowdefinition.md), [Grid](grid.md)
