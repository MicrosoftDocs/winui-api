---
-api-id: T:Microsoft.UI.Xaml.Input.PointerRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PointerRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.IPointerRoutedEventArgs
-->

# Microsoft.UI.Xaml.Input.PointerRoutedEventArgs

## -description

Contains the arguments returned by the last pointer event message.

## -remarks

In most cases, we recommend that you get pointer info through the event argument of the pointer event handlers in your chosen language framework (Windows app using JavaScript, UWP app using C++, C#, or Visual Basic, or UWP app using DirectX with C++).

If the event argument doesn't intrinsically expose the pointer details required by your app, you can get access to extended pointer data through the [GetCurrentPoint](pointerroutedeventargs_getcurrentpoint_293890010.md) and [GetIntermediatePoints](pointerroutedeventargs_getintermediatepoints_516826524.md) methods of PointerRoutedEventArgs. Use these methods to specify the context of the pointer data.

The PointerRoutedEventArgs event data class is used for these events:

+ [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md)
+ [PointerCanceled](../microsoft.ui.xaml/uielement_pointercanceled.md)
+ [PointerCaptureLost](../microsoft.ui.xaml/uielement_pointercapturelost.md)
+ [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md)
+ [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md)
+ [PointerMoved](../microsoft.ui.xaml/uielement_pointermoved.md)
+ [PointerReleased](../microsoft.ui.xaml/uielement_pointerreleased.md)
+ [PointerWheelChanged](../microsoft.ui.xaml/uielement_pointerwheelchanged.md)

> [!IMPORTANT]
> Mouse input is associated with a single pointer assigned when mouse input is first detected. Clicking a mouse button (left, wheel, or right) creates a secondary association between the pointer and that button through the [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md) event. The [PointerReleased](../microsoft.ui.xaml/uielement_pointerreleased.md) event is fired only when that same mouse button is released (no other button can be associated with the pointer until this event is complete). Because of this exclusive association, other mouse button clicks are routed through the [PointerMoved](../microsoft.ui.xaml/uielement_pointermoved.md) event. You can test the mouse button state when handling this event, as shown in the following example.

[!code-csharp[PointerMoved](../microsoft.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

[!code-csharp[PointerMoved](../microsoft.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

+ The value of *sender* (which is on the delegate signature, not this event data class).
+ Specific members of PointerRoutedEventArgs, such as [KeyModifiers](pointerroutedeventargs_keymodifiers.md) or [GetCurrentPoint](pointerroutedeventargs_getcurrentpoint_293890010.md).
+ Values of a [Pointer](pointer.md) device description class. Get the [Pointer](pointer.md) from the [Pointer](pointerroutedeventargs_pointer.md) property.
+ Members that come from the system input conceptualization of a [PointerPoint](../microsoft.ui.input/pointerpoint.md). Use the [GetCurrentPoint](pointerroutedeventargs_getcurrentpoint_293890010.md) API to get a [PointerPoint](../microsoft.ui.input/pointerpoint.md) value, then call [PointerPoint](../microsoft.ui.input/pointerpoint.md) API such as [Microsoft.UI.Input.PointerPoint.Position](../microsoft.ui.input/pointerpoint_position.md) and [PointerPointProperties](../microsoft.ui.input/pointerpointproperties.md).

Specific events often have information available in the various pointer device and pointer point classes that is mainly only relevant for that event. For example, when you handle [PointerWheelChanged](../microsoft.ui.xaml/uielement_pointerwheelchanged.md), you might be interested in the [MouseWheelDelta](../microsoft.ui.input/pointerpointproperties_mousewheeldelta.md) from [PointerPointProperties](../microsoft.ui.input/pointerpointproperties.md).

The object retrieved by the GetCurrentPoint and GetIntermediatePoints methods provide access to extended pointer info through the [Properties](../microsoft.ui.input/pointerpoint_properties.md) property, which gets a [PointerPointProperties](../microsoft.ui.input/pointerpointproperties.md) object.

In the following example, we get extended pointer properties through the [PointerPoint](../microsoft.ui.input/pointerpoint.md) and [PointerPointProperties](../microsoft.ui.input/pointerpointproperties.md) objects. (See [Quickstart: Pointers](/previous-versions/windows/apps/hh465383(v=win.10)) for the complete example.)

[!code-csharp[SnippetQueryPointer](../microsoft.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

Typically, the object returned by this method is used to feed pointer data to a [GestureRecognizer](../microsoft.ui.input/gesturerecognizer.md). Another scenario is getting the [MouseWheelDelta](../microsoft.ui.input/pointerpointproperties_mousewheeldelta.md) for a [PointerWheelChanged](../microsoft.ui.xaml/uielement_pointerwheelchanged.md) event; that value is in [PointerPointProperties](../microsoft.ui.input/pointerpointproperties.md).

## -examples
The following code example shows scenario 2 from the [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample). This code shows some usage patterns for direct manipulation using the [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md), [PointerReleased](../microsoft.ui.xaml/uielement_pointerreleased.md), [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md), [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md), and [PointerMoved](../microsoft.ui.xaml/uielement_pointermoved.md) events.



[!code-xaml[Scenario2Xaml](../microsoft.ui.xaml/code/input/csharp/Scenario2.xaml#SnippetScenario2Xaml)]

[!code-csharp[Scenario2Code](../microsoft.ui.xaml/code/input/csharp/Scenario2.xaml.cs#SnippetScenario2Code)]

[!code-vb[Scenario2Code](../microsoft.ui.xaml/code/input/vbnet/Scenario2.xaml.vb#SnippetScenario2Code)]

## -see-also
[RoutedEventArgs](../microsoft.ui.xaml/routedeventargs.md), [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md), [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md)
