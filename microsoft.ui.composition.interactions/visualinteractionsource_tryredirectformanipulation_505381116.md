---
-api-id: M:Microsoft.UI.Composition.Interactions.VisualInteractionSource.TryRedirectForManipulation(Microsoft.UI.Input.PointerPoint)
-api-type: winrt method
---

# Microsoft.UI.Composition.Interactions.VisualInteractionSource.TryRedirectForManipulation(Microsoft.UI.Input.PointerPoint)

<!--
public void TryRedirectForManipulation (Microsoft.UI.Input.PointerPoint pointerPoint);
-->

## -description

Attempts to send configured manipulations for the given pointer stream to the [InteractionTracker](interactiontracker.md), not the app's UI thread, starting at the given [PointerPoint](../microsoft.ui.input/pointerpoint.md).

> [!IMPORTANT]
> This method should only be called with a [PointerDeviceType](../microsoft.ui.input/pointerdevicetype.md) of Touch.

## -parameters

### -param pointerPoint

The input point.

## -remarks

This method enables the app to indicate that the system (Compositor) should take over any configured manipulations for a given [VisualInteractionSource](visualinteractionsource.md). When TryRedirectForManipulation is called, the frame from the passed in PointerPoint is used as the starting point for input handling by the [InteractionTracker](interactiontracker.md). If the user's gesture is hit-tested to the visual associated with the [VisualInteractionSource](visualinteractionsource.md) (or one of its children), and the user performs a configured gesture, then the system will manipulate. If the input is hit-tested to another visual or the user performs a non-configured gesture then the input will be sent to the [CoreWindow](../microsoft.ui.xaml/window_corewindow.md) and through standard input routing.

If the [VisualInteractionSource](visualinteractionsource.md) reroutes the input stream to the [InteractionTracker](interactiontracker.md), the application will receive an [InputPointerSource.PointerCaptureLost](../microsoft.ui.input/inputpointersource_pointercapturelost.md) on the UIElement, or an [InputPointerSource.PointerRoutedAway](../microsoft.ui.input/inputpointersource_pointerroutedaway.md) on the [CoreWindow](../microsoft.ui.xaml/window_corewindow.md). These messages indicate that the input has been sent away from the application UI thread. This method will be most commonly called on [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md).

> [!NOTE]
> PrecisionTouchpad input does not require this call and will be automatically routed to the [InteractionTracker](interactiontracker.md) for the appropriate gestures if the InputRedirectionMode has been set to include CapableTouchpad input.

### Async behavior

The nature of this system is asynchronous. By the time the app calls TryRedirectForManipulation and the call reaches the compositor, there will be additional input events that could have made it to the application's UI thread. In most cases, it is not harmful for the app to have received these events, and you can choose to gesture detect in your app to determine how to handle the input. The app will know whether the system manipulation takes over by receiving a [PointerCaptureLost](../microsoft.ui.xaml/uielement_pointercapturelost.md) (the same event received when ScrollViewer takes over input handling). One complication is that it is possible for a gesture like a "quick flick" (a short swipe) to send the entire input stream, including the PointerReleased, to the application before the compositor can respond. If your app is impacted by these limitations, you might need to do some gesture detection to ensure the right behavior.

### Integration with XAML controls logic

In the quick flick scenario described above, where the pan happens to be on a control like a button, the button will detect the pan as a click if it is contained within the button. This is slightly different than how the system GestureRecognizer that is doing the routing detects gestures. In order to ensure quick flick type scenarios work correctly with XAML, you need to listen for [OnTapped](../microsoft.ui.xaml.controls/control_ontapped_411888825.md) on the button rather than just [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) if it is within a compositor interaction area.

### Compositor hit-testing

The hit-test result used for determining if the manipulation is happening on the right visual will be based on the compositor's hit-testing. Compositor hit-testing is not as robust as XAML hit-testing, so there are cases where results could have a slight discrepancy.

### Integration With Conflicting Custom Gesture Recognizers

Internally, the system GestureRecognizer is being used to route input. Apps can generally get the behavior they want as long as they are using system gesture recognition. If your app is attempting to use a custom recognizer that conflicts with the system recognizer, there could be conflicts where the app expects the compositor to take over and it does not.

## -see-also

## -examples

The following code snippet shows how to configure a visual to follow input/gestures.  

This is accomplished through three primary steps:

1. Creating an [InteractionTracker](interactiontracker.md) and setting (or binding) it's boundaries.
2. Creating at least one [VisualInteractionSource](visualinteractionsource.md) and associating it with the InteractionTracker.
3. Taking the output of the InteractionTracker and applying it to the [Offset](../microsoft.ui.composition/visual_offset.md) and [Scale](../microsoft.ui.composition/visual_scale.md) properties of a [Visual](../microsoft.ui.composition/visual.md).
4. Telling the system to try to handle the manipulation when the [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md) occurs

```csharp
void SetupSimpleInteractionTracker(Visual containerVisual, Visual contentVisual)
{
  //
  // Create the InteractionTracker and set its min/max position and scale.
  // These could also be bound to expressions.
  //
  // Note: 
  // The scrollable area can be changed from either end for content updates/virtualization.
  //

  _tracker = InteractionTracker.Create(_compositor);

  _tracker.MaxPosition = new Vector3(
  contentVisual.Size.X - containerVisual.Size.X,
  contentVisual.Size.Y - containerVisual.Size.Y,
  0.0f);

  _tracker.MinScale = 0.5f;
  _tracker.MaxScale = 4.0f;


  //
  // Configure the interaction source.  Enable input with inertia on all axes.
  //

  _interactionSource = VisualInteractionSource.Create(_compositor, containerVisual);

  _interactionSource.PositionXSourceMode = InteractionSourceMode.EnabledWithInertia;
  _interactionSource.PositionYSourceMode = InteractionSourceMode.EnabledWithInertia;
  _interactionSource.ScaleSourceMode = InteractionSourceMode.EnabledWithInertia;

  _tracker.InteractionSources.Add(_interactionSource);

  //
  // Register for the pointer pressed event so that we can tell the system to handle the
  // manipulations.
  //

  _rootElement.PointerPressed += OnPointerPressedBasic;

  //
  // Bind the InteractionTracker outputs to the contentVisual.
  //

  var positionExpression = _compositor.CreateExpressionAnimation("-tracker.Position");
  positionExpression.SetReferenceParameter("tracker", _tracker);

  contentVisual.StartAnimation("Offset", positionExpression);


  var scaleExpression = _compositor.CreateExpressionAnimation("Vector3(tracker.Scale, tracker.Scale, 1.0)");

  scaleExpression.SetReferenceParameter("tracker", _tracker);

  contentVisual.StartAnimation("Scale", scaleExpression);
}

private void OnPointerPressedBasic(object sender, PointerRoutedEventArgs e)
{
  //
  // Try to handle the manipulation in the system.
  //
  if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Touch)
  {       
    _interactionSource.TryRedirectForManipulation(
    e.CurrentPoint.GetCurrentPoint(_rootElement));
  }
}

Compositor _compositor = null;
InteractionTracker _tracker = null;
UIElement _rootElement = null;
VisualInteractionSource _interactionSource;
         
         
```
