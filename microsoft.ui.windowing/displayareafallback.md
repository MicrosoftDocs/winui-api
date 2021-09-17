---
-api-id: T:Microsoft.UI.Windowing.DisplayAreaFallback
-api-type: winrt enum
---

# Microsoft.UI.Windowing.DisplayAreaFallback

<!--
public enum DisplayAreaFallback
-->

## -description

Defines constants that specify which `DisplayArea` to use if no `DisplayArea` intersects with the given parameter.

## -enum-fields

### -field None: 0

Do not use any `DisplayArea`; return `nullptr`.

### -field Primary: 1

Use the primary `DisplayArea`.

### -field Nearest: 2

Use the nearest `DisplayArea`.

## -remarks

## -see-also

[DisplayArea.Primary](displayarea_primary.md), [DisplayArea.GetFromPoint](displayarea_getfrompoint_615849610.md), [DisplayArea.GetFromRect](displayarea_getfromrect_1376380644.md), [DisplayArea.GetFromWindowId](displayarea_getfromwindowid_1017520019.md)

## -examples
