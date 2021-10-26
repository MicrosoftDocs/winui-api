---
-api-id: T:Microsoft.UI.Input.PointerPredictor
-api-type: winrt class
---

# Microsoft.UI.Input.PointerPredictor

<!--
public sealed class PointerPredictor : System.IDisposable
-->

## -description

Provides support for generating a collection of [PointerPoint](pointerpoint.md) objects that predict the most likely path of the current input [Pointer](../microsoft.ui.xaml.input/pointer.md).

## -remarks

This object is typically used to reduce rendering latency for ink input. In some cases, when a user draws very quickly, there can be a noticeable gap between the pen tip and the rendered ink.

## -see-also

## -examples

In the following example, we show how to consume the PointerPredictor object by receiving input for a SwapChainPanel on a background thread.

```csharp
class PointerPredictionRenderer : IDisposable
{
    private DispatcherQueueController _queuecontroller;
    private InputPointerSource _inputPointerSource;
    private PointerPredictor _pointerPredictor;

    private List<Point> _actualPoints = new List<Point>();
    private List<Point> _predictedPoints = new List<Point>();

    private SwapChainPanel _panel;

    public PointerPredictionRenderer(SwapChainPanel panel)
    {
        _panel = panel;
        _panel.Loaded += SwapChainPanel_Loaded;
    }

    private void SwapChainPanel_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        _queuecontroller = DispatcherQueueController.CreateOnDedicatedThread();
        _queuecontroller.DispatcherQueue.TryEnqueue(DispatcherQueuePriority.High,
            () =>
            {
                // Set up the pointer input source to receive pen input for the swap chain panel.
                _inputPointerSource = _panel.CreateCoreIndependentInputSource(InputPointerSourceDeviceKinds.Pen);
                _inputPointerSource.PointerPressed += InputPointerSource_PointerPressed;
                _inputPointerSource.PointerMoved += InputPointerSource_PointerMoved;
                _inputPointerSource.PointerReleased += InputPointerSource_PointerReleased;

                // Create the pointer predictor for the input pointer source. By default it will be configured
                // to predict points 15ms into the future
                _pointerPredictor = PointerPredictor.CreateForInputPointerSource(_inputPointerSource);
            });
    }

    ~PointerPredictionRenderer()
    {
        Dispose();
    }

    public void Dispose()
    {
        if (_pointerPredictor != null)
        {
            _pointerPredictor.Dispose();
            _pointerPredictor = null;
        }

        _inputPointerSource.PointerPressed -= InputPointerSource_PointerPressed;
        _inputPointerSource.PointerMoved -= InputPointerSource_PointerMoved;
        _inputPointerSource.PointerReleased -= InputPointerSource_PointerReleased;

        _inputPointerSource = null;
        _queuecontroller = null;
    }

    private void InputPointerSource_PointerPressed(InputPointerSource sender, PointerEventArgs args)
    {
        // Store the new point in contact.
        _actualPoints.Add(args.CurrentPoint.Position);
    }

    private void InputPointerSource_PointerMoved(InputPointerSource sender, PointerEventArgs args)
    {
        // Only render ink and query for predicted points when the pointer is in contact.
        // There are no predicted points if the pointer is not in contact.
        if (args.CurrentPoint.IsInContact)
        {
            // Store new points received in this event.
            var intermediatePoints = args.GetIntermediatePoints();
            foreach (var point in intermediatePoints)
            {
                _actualPoints.Add(point.Position);
            }

            // Query for the predicted points from the predictor.
            var predictedPoints = _pointerPredictor.GetPredictedPoints(args.CurrentPoint);
            if (predictedPoints != null)
            {
                foreach (var predictedPoint in predictedPoints)
                {
                    _predictedPoints.Add(predictedPoint.Position);
                }
            }

            // Render the new ink stroke and the predicted ink stroke.
            RenderInk();
        }
    }

    private void InputPointerSource_PointerReleased(InputPointerSource sender, PointerEventArgs args)
    {
        // Clear the stored ink points and erase the predicted ink rendered for this stroke.
        _actualPoints.Clear();
        ClearPredictedInk();
        _predictedPoints.Clear();
    }

    private void RenderInk()
    {
        // Render the ink strokes defined by _actualPoints and _predictedPoints.
        throw new NotImplementedException();
    }

    private void ClearPredictedInk()
    {
        // Clear the ink stroke defined by _predictedPoints.
        throw new NotImplementedException();
    }
}
```
