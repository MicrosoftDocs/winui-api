---
-api-id: M:Microsoft.UI.Xaml.Controls.UIElementCollection.ReplaceAll(Microsoft.UI.Xaml.UIElement[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Windows.UI.Xaml.UIElement[] items)
-->

# Microsoft.UI.Xaml.Controls.UIElementCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a "changed" event, the initial reset fires an event, but the items added do not fire discrete per-item events.

If you are programming using C# or Microsoft Visual Basic, there is no single-call equivalent to ReplaceAll. Use [Clear](uielementcollection_clear_556466.md) and then successive calls to [Add](/dotnet/api/system.collections.generic.icollection-1.add?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[Clear](uielementcollection_clear_556466.md)
