---
-api-id: M:Microsoft.UI.Xaml.Hosting.ElementCompositionPreview.SetElementChildVisual(Microsoft.UI.Xaml.UIElement,Microsoft.UI.Composition.Visual)
-api-type: winrt method
---

<!-- Method syntax
public void SetElementChildVisual(Windows.UI.Xaml.UIElement element, Windows.UI.Composition.Visual visual)
-->

# Microsoft.UI.Xaml.Hosting.ElementCompositionPreview.SetElementChildVisual

## -description
Sets a custom [Windows.UI.Composition.Visual](../microsoft.ui.composition/visual.md) as the last child of the element’s visual tree.

## -parameters
### -param element
The element to add the child [Visual](../microsoft.ui.composition/visual.md) to.

### -param visual
The [Visual](../microsoft.ui.composition/visual.md) to add to the element's visual tree.

## -remarks
The [Visual](../microsoft.ui.composition/visual.md) is added as the last child, therefore on top of the rest of the element in z-order.

## -examples

## -see-also
