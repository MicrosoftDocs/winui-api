---
-api-id: M:Microsoft.UI.Input.PointerPredictor.GetPredictedPoints(Microsoft.UI.Input.PointerPoint)
-api-type: winrt method
---

# Microsoft.UI.Input.PointerPredictor.GetPredictedPoints(Microsoft.UI.Input.PointerPoint)

<!--
public Microsoft.UI.Input.PointerPoint[] GetPredictedPoints (Microsoft.UI.Input.PointerPoint point);
-->

## -description

Retrieves a collection of predicted points for the specified [PointerPoint](pointerpoint.md).

## -parameters

### -param point

The current point from which to base the predicted points.

## -returns

A collection of predicted points and associated properties.

The prediction engine must process at least 10 input points before returning a collection of predicted input points. Otherwise it returns an empty collection.

## -remarks

Predicted [PointerPoint](pointerpoint.md) properties are [Timestamp](pointerpoint_timestamp.md), [Position](pointerpoint_position.md), [Pressure](pointerpointproperties_pressure.md), [XTilt](pointerpointproperties_xtilt.md), and [YTilt](pointerpointproperties_ytilt.md). All other properties are cloned from the PointerPoint specified.

The number of points returned depends on the [PredictionTime](pointerpredictor_predictiontime.md) and the reporting rate of the digitizer. For example: if the prediction time is 15ms (default) and the report rate of a pointer input is around 266Hz, the predictor will predict 4 points. If the report rate is around 133Hz, the predictor will predict 2 points.

## -see-also

## -examples
