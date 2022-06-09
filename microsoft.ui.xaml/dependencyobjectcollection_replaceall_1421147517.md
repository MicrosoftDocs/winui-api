---
-api-id: M:Microsoft.UI.Xaml.DependencyObjectCollection.ReplaceAll(Microsoft.UI.Xaml.DependencyObject[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Windows.UI.Xaml.DependencyObject[] items)
-->

# Microsoft.UI.Xaml.DependencyObjectCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a *changed* event, which this collection does do with **VectorChanged**, the initial reset fires an event, but the items added do not fire discrete per-item events.

## -examples

## -see-also
