---
-api-id: T:Microsoft.UI.Input.InputPointerSource
-api-type: winrt class
---

# Microsoft.UI.Input.InputPointerSource

<!--
public sealed class InputPointerSource : Microsoft.UI.Input.InputObject
-->

## -description

Represents an object that is registered to report pointer input and provides pointer cursor and input event handling.

## -remarks

The coordinate space for the pointer events is in the same coordinate space as the [SwapChainPanel](../microsoft.ui.xaml.controls/swapchainpanel.md) object.

### Event order

:::row:::
    :::column:::
        Normal Case
    :::column-end:::
    :::column:::
        The pointer events of InputPointerSource follow a guaranteed order under normal circumstances:

        1. PointerEntered
        1. PointerPressed
        1. PointerMoved
        1. PointerReleased
        1. PointerExited
            
        Where [PointerMoved](inputpointersource_pointermoved.md) will only be raised if the pointer moves or the button states on the mouse change. All events have the same pointer id.
        
    :::column-end:::
:::row-end:::
:::row:::
    :::column:::
        Pointer capture lost
    :::column-end:::
    :::column:::
        [PointerCaptureLost](inputpointersource_pointercapturelost.md) is raised when an in-contact pointer is routed to a different input target by the input system. When PointerCaptureLost is raised, which will only happen after [PointerPressed](inputpointersource_pointerpressed.md) has been received, no additional events will be raised for that pointer. Specifically, [PointerReleased](inputpointersource_pointerreleased.md) and [PointerExited](inputpointersource_pointerexited.md) will not be raised, so you should handle PointerCaptureLost as a valid end state for a given pointer. Here is an example of a valid sequence of events that includes losing pointer capture:

        1. PointerEntered
        1. PointerPressed
        1. PointerMoved
        1. PointerCaptureLost
                    
    :::column-end:::
:::row-end:::

### Routed events

Pointer routed events are raised when an in-contact pointer is routed to a different input target by the input system. Unlike PointerCaptureLost, the routed events provide the possibility of the in-contact pointer being routed back before the pointer is released.

The following shows a valid sequence of events where the in-contact pointer is routed away to a different target, routed back to the original InputPointerSource, and then released:

1. PointerEntered
1. PointerPressed
1. PointerMoved
1. PointerRoutedAway
1. PointerRoutedTo
1. PointerReleased
1. PointerExited

Here is an example of a valid sequence of events where an in-contact pointer is routed away to a different target and then released on the other target:

1. PointerEntered
1. PointerPressed
1. PointerMoved
1. PointerRoutedAway
1. PointerRoutedReleased

> [!NOTE]
> When PointerRoutedReleased is raised, no additional events will be raised for that pointer. Specifically, [PointerReleased](inputpointersource_pointerreleased.md) and [PointerExited](inputpointersource_pointerexited.md) will not be raised, so you should handle PointerRoutedReleased as a valid end state for a given pointer.

It is also possible to receive a brand new in-contact pointer that was routed from a different target. In this case, the [PointerEntered](inputpointersource_pointerentered.md) and [PointerPressed](inputpointersource_pointerpressed.md) events are guaranteed to precede a [PointerRoutedTo](inputpointersource_pointerroutedto.md) if the pointer has not been seen by the current InputPointerSource yet. The following is an example of this sequence of events:

1. PointerEntered
1. PointerPressed
1. PointerRoutedTo
1. PointerMoved
1. PointerReleased
1. PointerExited

## -see-also

[CreateForInputPointerSource(Microsoft.UI.Input.InputPointerSource)](pointerpredictor_createforinputpointersource_1467140847.md)

## -examples

The following example shows how to configure a [SwapChainPanel](../microsoft.ui.xaml.controls/swapchainpanel.md) to receive low-latency pen and touch input on a background thread using [CreateCoreIndependentInputSource](../microsoft.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource_467679991.md):

```csharp
void SetupBackgroundPenInput(SwapChainPanel swapChainPanel)
{
    m_inputPointerSource = swapChainPanel.CreateCoreIndependentInputSource(
        InputPointerSourceDeviceKinds.Pen |
        InputPointerSourceDeviceKinds.Touch);

    m_inputPointerSource.PointerMoved += OnPointerMoved;
}

void OnPointerMoved(InputPointerSource source, PointerEventArgs args)
{
    PointerPoint point = args.CurrentPoint;

    DrawToPoint(point.Position.X, point.Position.Y);
}
```

This example shows how to configure the system hand cursor image to display when the cursor hovers over a SwapChainPanel:

```csharp
m_inputPointerSource = swapChainPanel.CreateCoreIndependentInputSource(
    InputPointerSourceDeviceKinds.Pen |
    InputPointerSourceDeviceKinds.Touch |
    InputPointerSourceDeviceKinds.Mouse);

m_inputPointerSource.InputCursor = InputSystemCursor.Create(InputSystemCursorShape.Hand);
```
