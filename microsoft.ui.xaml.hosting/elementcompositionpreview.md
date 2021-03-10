---
-api-id: T:Microsoft.UI.Xaml.Hosting.ElementCompositionPreview
-api-type: winrt class
---

<!-- Class syntax.
public class ElementCompositionPreview : Windows.UI.Xaml.Hosting.IElementCompositionPreview
-->

# Microsoft.UI.Xaml.Hosting.ElementCompositionPreview

## -description
Enables access to composition visual objects that back XAML elements in the XAML composition tree.

## -remarks
ElementCompositionPreview allows access to the [Windows.UI.Composition.Visual](../microsoft.ui.composition/visual.md) object backing a XAML element with the [GetElementVisual](elementcompositionpreview_getelementvisual_580363760.md) method. Once the backing object has been retrieved it can be manipulated using the [Windows.UI.Composition](/uwp/api/windows.ui.composition) namespace. This allows properties of the object to be changed, like the orientation, or additional objects to be added to the XAML composition tree.

## -examples

## -see-also
