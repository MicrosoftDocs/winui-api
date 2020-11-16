---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.SnapPointsAlignment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Primitives.SnapPointsAlignment : int
-->

# SnapPointsAlignment

## -description
Defines constants that specify options for snap point alignment relative to an edge. Which edge depends on the orientation of the object where the alignment is applied.

## -xaml-syntax
```xaml
<object property="enumMemberName" />
```


## -enum-fields
### -field Near:0
Use snap points grouped closer to the orientation edge.

### -field Center:1
Use snap points that are centered in the orientation.

### -field Far:2
Use snap points grouped farther from the orientation edge.


## -remarks
This enumeration is used as a value by [ScrollViewer.HorizontalSnapPointsAlignment](../microsoft.ui.xaml.controls/scrollviewer_horizontalsnappointsalignment.md) and [ScrollViewer.VerticalSnapPointsAlignment](../microsoft.ui.xaml.controls/scrollviewer_verticalsnappointsalignment.md). It's also used as a parameter type for [IScrollSnapPointsInfo.GetIrregularSnapPoints](iscrollsnappointsinfo_getirregularsnappoints_49277403.md) and [IScrollSnapPointsInfo.GetRegularSnapPoints](iscrollsnappointsinfo_getregularsnappoints_227309818.md), and implementations of those methods on types, such as [StackPanel.GetIrregularSnapPoints](/uwp/api/windows.ui.xaml.controls.stackpanel.getirregularsnappoints(windows.ui.xaml.controls.orientation,windows.ui.xaml.controls.primitives.snappointsalignment)).

For a vertically oriented element, **Near** is the top and **Far** is the bottom. For a horizontally oriented element, **Near** is left and **Far** is right.

To learn more about the swipe gesture and panning, see the "Panning behaviors" section of [Guidelines for panning](/windows/uwp/input-and-devices/guidelines-for-panning).


<!--Does RTL change these assumptions?-->

## -examples

## -see-also
[ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md), [IScrollSnapPointsInfo](iscrollsnappointsinfo.md)
