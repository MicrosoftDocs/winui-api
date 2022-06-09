---
-api-id: M:Microsoft.UI.Xaml.Media.GradientStopCollection.ReplaceAll(Microsoft.UI.Xaml.Media.GradientStop[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Windows.UI.Xaml.Media.GradientStop[] items)
-->

# Microsoft.UI.Xaml.Media.GradientStopCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a "changed" event, the initial reset fires an event, but the items added do not fire discrete events.

## -examples

## -see-also
