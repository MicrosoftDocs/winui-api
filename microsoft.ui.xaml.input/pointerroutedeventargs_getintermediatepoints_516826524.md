---
-api-id: M:Microsoft.UI.Xaml.Input.PointerRoutedEventArgs.GetIntermediatePoints(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Input.PointerPoint> GetIntermediatePoints(Windows.UI.Xaml.UIElement relativeTo)
-->

# Microsoft.UI.Xaml.Input.PointerRoutedEventArgs.GetIntermediatePoints

## -description
Retrieves a collection of [PointerPoint](../microsoft.ui.input/pointerpoint.md) objects that represent the pointer history from the last pointer event up to and including the current pointer event. Each [PointerPoint](../microsoft.ui.input/pointerpoint.md) in the collection provides basic info on the pointer associated with the event.The last item in the collection is equivalent to the [PointerPoint](../microsoft.ui.input/pointerpoint.md) object returned by [GetCurrentPoint](pointerroutedeventargs_getcurrentpoint_293890010.md).

## -parameters
### -param relativeTo
Provides the context for the pointer data. Can be any [UIElement](../microsoft.ui.xaml/uielement.md)-derived object that is connected to the same object tree. If **null**, location coordinates are in the context of the app.

## -returns
The collection of [PointerPoint](../microsoft.ui.input/pointerpoint.md) objects corresponding to the pointer history associated with the event. If *relativeTo* is **null**, location coordinates are in the context of the app. Otherwise, the coordinates are relative to the object referenced by *relativeTo*.

## -remarks

## -examples

## -see-also
