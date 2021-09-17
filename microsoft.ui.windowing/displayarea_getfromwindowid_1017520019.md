---
-api-id: M:Microsoft.UI.Windowing.DisplayArea.GetFromWindowId(Microsoft.UI.WindowId,Microsoft.UI.Windowing.DisplayAreaFallback)
-api-type: winrt method
---

# Microsoft.UI.Windowing.DisplayArea.GetFromWindowId(Microsoft.UI.WindowId,Microsoft.UI.Windowing.DisplayAreaFallback)

<!--
public static Microsoft.UI.Windowing.DisplayArea GetFromWindowId (Microsoft.UI.WindowId windowId, Microsoft.UI.Windowing.DisplayAreaFallback displayAreaFallback);
-->

## -description

Gets the `DisplayArea` for the specified `WindowId`.

## -parameters

### -param windowId

The identifer of the window for which to get the `DisplayArea`.

### -param displayAreaFallback

The `DisplayArea` to use if no `DisplayArea` is found with the given parameter.

## -returns

The `DisplayArea` for the specified `WindowId`, or the display area indicated by _displayAreaFallback_ if no match is found.

## -remarks

## -see-also

[DisplayArea](displayarea.md)

## -examples
