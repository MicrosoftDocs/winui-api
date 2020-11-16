---
-api-id: M:Microsoft.UI.Xaml.Controls.ListViewBase.MakeVisible(Microsoft.UI.Xaml.Controls.SemanticZoomLocation)
-api-type: winrt method
---

<!-- Method syntax
public void MakeVisible(Windows.UI.Xaml.Controls.SemanticZoomLocation item)
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.MakeVisible

## -description
Forces content in the view to scroll until the item that's specified by [SemanticZoomLocation](semanticzoomlocation.md) is visible. Also focuses the item if it finds the item.

## -parameters
### -param item
The item in the view to scroll to.

## -remarks
You use the MakeVisible method to bring an item into view when the [ListViewBase](listviewbase.md) control is used as a view in a [SemanticZoom](semanticzoom.md) control. To bring an item into view when the [ListViewBase](listviewbase.md) control is not used in a [SemanticZoom](semanticzoom.md), use the [ScrollIntoView](listviewbase_scrollintoview_632406320.md) method instead.

## -examples

## -see-also
[ScrollIntoView](listviewbase_scrollintoview_632406320.md), [SemanticZoom](semanticzoom.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange_1917507883.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom_996733196.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto_400609881.md), [InitializeViewChange](listviewbase_initializeviewchange_1165335344.md), [StartViewChangeFrom](listviewbase_startviewchangefrom_1194830824.md), [StartViewChangeTo](listviewbase_startviewchangeto_1278247285.md)
