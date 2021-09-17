---
-api-id: M:Microsoft.UI.Windowing.DisplayArea.CreateWatcher
-api-type: winrt method
---

# Microsoft.UI.Windowing.DisplayArea.CreateWatcher

<!--
public static Microsoft.UI.Windowing.DisplayAreaWatcher CreateWatcher ();
-->

## -description

Creates a `DisplayAreaWatcher` that notifies when a `DisplayArea` or the collection of display areas has changed.

## -returns

A new instance of `DisplayAreaWatcher`.

## -remarks

A [DisplayAreaWatcher](displayareawatcher.md) enumerates [DisplayArea](displayarea.md) objects and raises events when the collection of display areas changes, or if the configuration of an individual `DisplayArea` has changed.

> [!NOTE]
> You must create the `DisplayAreaWatcher` on a UI thread.

## -see-also

[DisplayArea](displayarea.md), [DisplayAreaWatcher](displayareawatcher.md)

## -examples
