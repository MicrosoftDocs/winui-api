---
-api-id: M:Microsoft.UI.Xaml.TriggerCollection.GetMany(System.UInt32,Microsoft.UI.Xaml.TriggerBase[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(System.UInt32 startIndex, Windows.UI.Xaml.TriggerBase[] items)
-->

# Microsoft.UI.Xaml.TriggerCollection.GetMany

## -description
Retrieves multiple elements in a single pass through the iterator.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param startIndex
The index from which to start retrieval.

### -param items
Provides the destination for the result. Size the initial array size as a *capacity* in order to specify how many results should be retrieved.

## -returns
The number of items retrieved.

## -remarks
> [!NOTE]
> The equivalent Microsoft .NET  API is [CopyTo](triggercollection_copyto.md).

## -examples

## -see-also
