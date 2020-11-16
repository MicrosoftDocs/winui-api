---
-api-id: P:Microsoft.UI.Xaml.Controls.Hub.IsActiveView
-api-type: winrt property
---

<!-- Property syntax
public bool IsActiveView { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Hub.IsActiveView

## -description
Gets or sets a value that indicates whether the [Hub](hub.md) instance is the active view in its owning [SemanticZoom](semanticzoom.md).

## -property-value
**true** if the [Hub](hub.md) is the active view; otherwise, **false**.

## -remarks
You typically don't set this property in XAML or in app code. The property is set implicitly when the view is set as either the [ZoomedInView](semanticzoom_zoomedinview.md) or [ZoomedOutView](semanticzoom_zoomedoutview.md) of a [SemanticZoom](semanticzoom.md) control.

## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [SemanticZoom.IsZoomedInViewActive](semanticzoom_iszoomedinviewactive.md), [ISemanticZoomInformation.IsActiveView](isemanticzoominformation_isactiveview.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsZoomedInView](hub_iszoomedinview.md), [SemanticZoomOwner](hub_semanticzoomowner.md), [CompleteViewChange](hub_completeviewchange_1917507883.md), [CompleteViewChangeFrom](hub_completeviewchangefrom_996733196.md), [CompleteViewChangeTo](hub_completeviewchangeto_400609881.md), [InitializeViewChange](hub_initializeviewchange_1165335344.md), [MakeVisible](hub_makevisible_497090924.md), [StartViewChangeFrom](hub_startviewchangefrom_1194830824.md), [StartViewChangeTo](hub_startviewchangeto_1278247285.md)
