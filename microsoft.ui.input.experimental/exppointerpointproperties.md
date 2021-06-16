---
-api-id: T:Microsoft.UI.Input.Experimental.ExpPointerPointProperties
-api-type: winrt class
---

# Microsoft.UI.Input.Experimental.ExpPointerPointProperties

<!--
public sealed class ExpPointerPointProperties
-->

## -description

> [!CAUTION]
> This API is in development and considered experimental in the WinUI version selected. It might be altered or unavailable in other versions.

Provides extended properties for a [ExpPointerPoint](exppointerpoint.md) object.

## -remarks

The `ExpPointerPointProperties` coordinate space is dependent on the context in which it is retrieved. When retrieved from [Microsoft.UI.Xaml.Input.PointerRoutedEventArgs.GetCurrentPoint](../microsoft.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_293890010.md), the coordinates of the pointer will be relative to the provided `UIElement` in device independent pixels.

> [!NOTE]
> Extended Human Interface Device (HID) usage data is not currently available on `ExpPointerPointProperties` objects.

> [!NOTE]
> This class is not agile, which means its functions and properties may only be accessed on the UI thread from where it was retrieved. Access on a different thread will return `RPC_E_WRONG_THREAD` or the equivalent projected error type.

## -see-also
[ExpPointerPoint](exppointerpointproperties.md), [Microsoft.UI.Xaml.Input.PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md)

## -examples
