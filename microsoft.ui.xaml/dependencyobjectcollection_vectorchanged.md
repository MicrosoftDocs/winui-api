---
-api-id: E:Microsoft.UI.Xaml.DependencyObjectCollection.VectorChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.Collections.VectorChangedEventHandler VectorChanged<Windows.UI.Xaml.DependencyObject>
-->

# Microsoft.UI.Xaml.DependencyObjectCollection.VectorChanged

## -description
Occurs when the contents of the collection changes.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
This event is named **VectorChanged** for all languages, but for C# and Microsoft Visual Basic the implemented collection type is [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true).

The type of change that was applied to the collection is communicated as a [CollectionChange](/uwp/api/windows.foundation.collections.collectionchange) value in the event data, with a collection index for where in the collection the change occurred. Because it reports per-index, multiple **VectorChanged** events can originate from the same collection at the same time.

## -examples

## -see-also
[IVectorChangedEventArgs](/uwp/api/windows.foundation.collections.ivectorchangedeventargs)
