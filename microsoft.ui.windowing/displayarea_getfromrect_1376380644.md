---
-api-id: M:Microsoft.UI.Windowing.DisplayArea.GetFromRect(Windows.Graphics.RectInt32,Microsoft.UI.Windowing.DisplayAreaFallback)
-api-type: winrt method
---

# Microsoft.UI.Windowing.DisplayArea.GetFromRect(Windows.Graphics.RectInt32,Microsoft.UI.Windowing.DisplayAreaFallback)

<!--
public static Microsoft.UI.Windowing.DisplayArea GetFromRect (Windows.Graphics.RectInt32 rect, Microsoft.UI.Windowing.DisplayAreaFallback displayAreaFallback);
-->

## -description

Gets the `DisplayArea` where the specified rectangle is present.

## -parameters

### -param rect

The rectangle for which to get the `DisplayArea`.

### -param displayAreaFallback

The `DisplayArea` to use if no `DisplayArea` is found with the given parameter.

## -returns

The `DisplayArea` where the specified rectangle is present, or the display area indicated by _displayAreaFallback_ if no match is found.

## -remarks

## -see-also

[DisplayArea](displayarea.md)

## -examples
