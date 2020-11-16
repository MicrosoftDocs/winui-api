---
-api-id: M:Microsoft.UI.Xaml.Input.ContextRequestedEventArgs.TryGetPosition(Microsoft.UI.Xaml.UIElement,Windows.Foundation.Point@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryGetPosition(Windows.UI.Xaml.UIElement relativeTo, Windows.Foundation.Point point)
-->

# Microsoft.UI.Xaml.Input.ContextRequestedEventArgs.TryGetPosition

## -description
Gets the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin of a supplied [UIElement](../microsoft.ui.xaml/uielement.md).

## -parameters
### -param relativeTo
Any [UIElement](../microsoft.ui.xaml/uielement.md)-derived object that is connected to the same object tree. To specify the object relative to the overall coordinate system, use a *relativeTo*  value of **null**.

### -param point
A [Point](/uwp/api/windows.foundation.point) that represents the current x- and y-coordinates of the mouse pointer position. If **null** was passed as *relativeTo*, this coordinate is for the overall window. If a *relativeTo* value other than **null** was passed, this coordinate is relative to the object referenced by *relativeTo*.

## -returns
**true** if the context request was initiated by a pointer device; otherwise, **false**.

## -remarks

## -examples

## -see-also
