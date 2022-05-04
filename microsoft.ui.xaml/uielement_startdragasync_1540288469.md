---
-api-id: M:Microsoft.UI.Xaml.UIElement.StartDragAsync(Microsoft.UI.Input.PointerPoint)
-api-type: winrt method
---

# Microsoft.UI.Xaml.UIElement.StartDragAsync(Microsoft.UI.Input.PointerPoint)

<!--
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.DataTransfer.DataPackageOperation> StartDragAsync (Microsoft.UI.Input.PointerPoint pointerPoint);
-->

## -description

Initiates a drag-and-drop operation.

> [!Important]
> Not supported if a user runs the app in elevated mode, as an administrator.

## -parameters

### -param pointerPoint

The coordinates of the pointer where the user interacts with the screen, and where the drag visual is attached.

## -returns

A <xref:Windows.ApplicationModel.DataTransfer.DataPackageOperation?displayProperty=nameWithType> value that indicates the type of drag-and-drop operation, and whether the operation was successful.

## -remarks

If you implement custom gesture detection to initiate a drag operation, you can call the <xref:Microsoft.UI.Xaml.UIElement.StartDragAsync(Microsoft.UI.Input.PointerPoint)?displayProperty=nameWithType> method to programmatically initiate a drag operation on any UIElement. Calling this method results in the <xref:Microsoft.UI.Xaml.UIElement.DragStarting?displayProperty=nameWithType> event being raised. Handle the DragStarting event to specify other properties of the operation, such as the data package and drag visual.

The *pointerPoint* parameter is the point at which the user interacts with the screen using an input device (touch, mouse, or pen). The drag visual that is shown during the drag operation is attached to the pointer indicated in the caller-provided <xref:Microsoft.UI.Input.PointerPoint>.

The <xref:Microsoft.UI.Xaml.UIElement.StartDragAsync(Microsoft.UI.Input.PointerPoint)?displayProperty=nameWithType> returned by this method indicates whether the drag operation is a move, copy, or link; and whether or not it's a success. This is the same value that's provided by the <xref:Microsoft.UI.Xaml.DropCompletedEventArgs.DropResult?displayProperty=nameWithType> property.

## -see-also

## -examples
