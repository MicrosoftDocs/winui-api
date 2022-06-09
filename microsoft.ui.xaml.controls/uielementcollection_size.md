---
-api-id: P:Microsoft.UI.Xaml.Controls.UIElementCollection.Size
-api-type: winrt property
---

<!-- Property syntax
public uint Size { get; }
-->

# Microsoft.UI.Xaml.Controls.UIElementCollection.Size

## -description
Gets the size (count) of the collection.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The count of items in the collection.

## -remarks
The Size value returns the true number of items. API that use the index, such as [GetAt](uielementcollection_getat_496709656.md), use a zero-based index, so you would subtract one from Size in order to specify that you want the last item in the collection.

If you are programming using C# or Microsoft Visual Basic, see [Count](/dotnet/api/system.collections.generic.icollection-1.count?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
