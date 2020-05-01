---
-api-id: P:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.LayoutOrigin
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.LayoutOrigin

<!--
public Windows.Foundation.Point LayoutOrigin { get; set; }
-->

## -description

Gets or sets the origin point for the estimated content size.

## -property-value

The origin point for the estimated content size.

## -remarks

LayoutOrigin is used by virtualizing layouts that rely on estimations when determining the size and position of content. It allows the layout to fix-up the estimated origin of the content as it changes due to on-going estimation or potentially identifying the actual size to use. For example, it’s possible that as a user is scrolling back to the top of the content that the layout's estimates for the content size that it reports as part of its MeasureOverride become increasingly accurate. If the predicted position of the content does not already match the previously predicted position (for example, if the size of the elements ends up being smaller than previously thought), then the layout can indicate a new origin. The viewport provided to the layout on subsequent passes will take into account the adjusted origin.

## -see-also

## -examples

