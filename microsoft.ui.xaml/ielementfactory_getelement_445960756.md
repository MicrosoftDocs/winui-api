---
-api-id: M:Microsoft.UI.Xaml.IElementFactory.GetElement(Microsoft.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
---

<!-- Method syntax.
public UIElement IElementFactory.GetElement(ElementFactoryGetArgs args)
-->

# Microsoft.UI.Xaml.IElementFactory.GetElement

## -description

Gets an [UIElement](uielement.md) object.

## -parameters

### -param args

An instance of [ElementFactoryGetArgs](elementfactorygetargs.md).

## -returns

A [UIElement](uielement.md) object.

## -remarks

When you call GetElement, the [UIElement](uielement.md) object that is returned can be added to the visual tree of another [UIElement](uielement.md). GetElement is not required to create a new instance each time it is invoked. The [UIElement](uielement.md) being returned may be an existing instance that has been prepared for re-use.  

For more info, see the remarks for the [DataTemplate.GetElement](datatemplate_getelement_445960756.md) method.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](/uwp/api/windows.ui.xaml.datatemplate.getelement), [DataTemplate.RecycleElement](/uwp/api/windows.ui.xaml.datatemplate.recycleelement), [DataTemplateSelector.GetElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.getelement), [DataTemplateSelector.RecycleElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.recycleelement)

## -examples
