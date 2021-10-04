---
-api-id: P:Microsoft.UI.Dispatching.DispatcherQueueTimer.IsRepeating
-api-type: winrt property
---

# Microsoft.UI.Dispatching.DispatcherQueueTimer.IsRepeating

<!--
public bool IsRepeating { get; set; }
-->

## -description

Gets or sets whether the timer is repeating.

## -property-value

**True** indicates that the timer fires every **DispatcherQueueTimer.Interval**.

**False** indicates that the timer fires once, after **DispatcherQueueTimer.Interval** elapses.

## -remarks

If you change the **IsRepeating** value while the timer is running, the timer will restart with the new value.

## -see-also

## -examples
