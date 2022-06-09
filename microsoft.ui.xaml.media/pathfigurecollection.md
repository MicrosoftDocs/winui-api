---
-api-id: T:Microsoft.UI.Xaml.Media.PathFigureCollection
-api-type: winrt class
---

<!-- Class syntax.
public class PathFigureCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.PathFigure>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.PathFigure>
-->

# Microsoft.UI.Xaml.Media.PathFigureCollection

## -description
Represents a collection of [PathFigure](pathfigure.md) objects that collectively make up the geometry of a [PathGeometry](pathgeometry.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<object>
  <object.property>
    oneOrMorePathFigures
  </object.property>
</object>
- or -
<object property="drawingCommands" ...>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A PathFigureCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<PathFigure>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [PathFigure](pathfigure.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector`1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable`1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
