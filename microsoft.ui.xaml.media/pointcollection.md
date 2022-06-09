---
-api-id: T:Microsoft.UI.Xaml.Media.PointCollection
-api-type: winrt class
---

<!-- Class syntax.
public class PointCollection : Windows.Foundation.Collections.IIterable<Windows.Foundation.Point>, Windows.Foundation.Collections.IVector<Windows.Foundation.Point>
-->

# Microsoft.UI.Xaml.Media.PointCollection

## -description
Represents a collection of [Point](/uwp/api/windows.foundation.point) values that can be individually accessed by index.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<object property="oneOrMorePoints"/>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A PointCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Point>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [Point](/uwp/api/windows.foundation.point) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector`1), [IIterable<T>](/uwp/api/windows.foundation.collections.iiterable_t_), @T:System.Collections.Generic.IList`1
