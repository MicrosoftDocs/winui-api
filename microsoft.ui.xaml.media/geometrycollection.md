---
-api-id: T:Microsoft.UI.Xaml.Media.GeometryCollection
-api-type: winrt class
---

<!-- Class syntax.
public class GeometryCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.Geometry>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.Geometry>
-->

# Microsoft.UI.Xaml.Media.GeometryCollection

## -description
Represents a collection of [Geometry](geometry.md) objects.

## -xaml-syntax
```xaml
<object>
  <object.property>
    oneOrMoreGeometryObjectElements
  </object.property>
</object>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A GeometryCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Geometry>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [Geometry](geometry.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector`1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable`1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
