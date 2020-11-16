---
-api-id: M:Microsoft.UI.Text.ITextRange.GetPoint(Microsoft.UI.Text.HorizontalCharacterAlignment,Microsoft.UI.Text.VerticalCharacterAlignment,Microsoft.UI.Text.PointOptions,Windows.Foundation.Point@)
-api-type: winrt method
---

<!-- Method syntax
public void GetPoint(Windows.UI.Text.HorizontalCharacterAlignment horizontalAlign, Windows.UI.Text.VerticalCharacterAlignment verticalAlign, Windows.UI.Text.PointOptions options, Windows.Foundation.Point point)
-->

# Microsoft.UI.Text.ITextRange.GetPoint

## -description
Retrieves the screen coordinates of a particular location in the text range.

## -parameters
### -param horizontalAlign
The horizontal position to retrieve, relative to the bounding rectangle of the text range.

### -param verticalAlign
The vertical position to retrieve, relative to the bounding rectangle of the text range.

### -param options
The options for retrieving the coordinates of the specified location in the text range.

### -param point
A structure that receives the coordinates of the specified location in the text range, represented as an ordered pair of floating-point x- and y-coordinates that define a point in a two-dimensional plane.

## -remarks
This method lets an app emulate pointer commands, which is particularly useful for implementing accessibility scenarios.

## -examples

## -see-also
[ITextRange.SetPoint](itextrange_setpoint_2090960387.md)
