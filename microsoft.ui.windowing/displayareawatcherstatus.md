---
-api-id: T:Microsoft.UI.Windowing.DisplayAreaWatcherStatus
-api-type: winrt enum
---

# Microsoft.UI.Windowing.DisplayAreaWatcherStatus

<!--
public enum DisplayAreaWatcherStatus
-->

## -description

Defines constants that specify the status of a `DisplayAreaWatcher`.

## -enum-fields

### -field Created: 0

The watcher has been created.

### -field Started: 1

The watcher has started.

### -field EnumerationCompleted: 2

The watcher has finished enumerating the display areas.

### -field Stopping: 3

The watcher is stopping.

### -field Stopped: 4

The watcher has stopped.

### -field Aborted: 5

The watcher has stopped before completing enumeration of display areas.

## -remarks

Values of this enumeration are used by the [DisplayAreaWatcher.Status](displayareawatcher_status.md) property.

## -see-also

[DisplayAreaWatcher.Status](displayareawatcher_status.md)

## -examples
