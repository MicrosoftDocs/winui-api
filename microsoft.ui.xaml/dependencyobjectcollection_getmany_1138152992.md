---
-api-id: M:Microsoft.UI.Xaml.DependencyObjectCollection.GetMany(System.UInt32,Microsoft.UI.Xaml.DependencyObject[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(System.UInt32 startIndex, Windows.UI.Xaml.DependencyObject[] items)
-->

# Microsoft.UI.Xaml.DependencyObjectCollection.GetMany

## -description
Retrieves multiple elements in a single pass through the iterator.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param startIndex
The index from which to start retrieval.

### -param items
Provides the destination for the result. Size the initial array size as a *capacity* in order to specify how many results should be retrieved.

## -returns
The number of items returned.

## -remarks
> [!NOTE]
> The equivalent Microsoft .NET  API is [CopyTo](dependencyobjectcollection_copyto.md).

## -examples

## -see-also
