---
-api-id: P:Microsoft.UI.Xaml.Controls.ListViewBase.IsZoomedInView
-api-type: winrt property
---

<!-- Property syntax
public bool IsZoomedInView { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.IsZoomedInView

## -description
Gets or sets a value that indicates whether the [ListViewBase](listviewbase.md) instance is the zoomed-in view in its owning [SemanticZoom](semanticzoom.md).

## -property-value
**true** if the [ListViewBase](listviewbase.md) is the zoomed-in view; otherwise, **false**.

## -remarks
You typically don't set this property in XAML or in app code. The property is set implicitly when the view is set as either the [ZoomedInView](semanticzoom_zoomedinview.md) or [ZoomedOutView](semanticzoom_zoomedoutview.md) of a [SemanticZoom](semanticzoom.md) control.

## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [SemanticZoom.IsZoomedInViewActive](semanticzoom_iszoomedinviewactive.md), [ISemanticZoomInformation.IsZoomedInView](isemanticzoominformation_iszoomedinview.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](listviewbase_isactiveview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange_1917507883.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom_996733196.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto_400609881.md), [InitializeViewChange](listviewbase_initializeviewchange_1165335344.md), [MakeVisible](listviewbase_makevisible_497090924.md), [StartViewChangeFrom](listviewbase_startviewchangefrom_1194830824.md), [StartViewChangeTo](listviewbase_startviewchangeto_1278247285.md)
