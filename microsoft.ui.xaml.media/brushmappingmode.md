---
-api-id: T:Microsoft.UI.Xaml.Media.BrushMappingMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.BrushMappingMode : int
-->

# BrushMappingMode

## -description
Specifies the coordinate system used by a [Brush](brush.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field Absolute:0
The coordinate system is not relative to a bounding box. Values are interpreted directly in local space.

### -field RelativeToBoundingBox:1
The coordinate system is relative to a bounding box: 0 indicates 0 percent of the bounding box, and 1 indicates 100 percent of the bounding box. For example, (0.5, 0.5) describes a point in the middle of the bounding box, and (1, 1) describes a point at the lower right of the bounding box.


## -remarks

## -examples

## -see-also
