---
-api-id: M:Microsoft.UI.Xaml.Controls.DataTemplateSelector.GetElement(Microsoft.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
---

<!-- Method syntax.
public UIElement DataTemplateSelector.GetElement(ElementFactoryGetArgs args)
-->

# Microsoft.UI.Xaml.Controls.DataTemplateSelector.GetElement

## -description

Creates or retrieves an existing instance of the [UIElement](../microsoft.ui.xaml/uielement.md) object declared in the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) returned by [SelectTemplate](datatemplateselector_selecttemplate_737484049.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters

### -param args

An instance of [ElementFactoryGetArgs](../microsoft.ui.xaml/elementfactorygetargs.md).

## -returns

An instance of the root [UIElement](../microsoft.ui.xaml/uielement.md) declared in the selected [DataTemplate](../microsoft.ui.xaml/datatemplate.md) or, **null** if the root of the selected [DataTemplate](../microsoft.ui.xaml/datatemplate.md) is not a [UIElement](../microsoft.ui.xaml/uielement.md).

## -remarks

For more info, see the remarks for the [DataTemplate.GetElement](/uwp/api/windows.ui.xaml.datatemplate.getelement(windows.ui.xaml.elementfactorygetargs)) method.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](/uwp/api/windows.ui.xaml.datatemplate.getelement), [DataTemplate.RecycleElement](/uwp/api/windows.ui.xaml.datatemplate.recycleelement), [DataTemplateSelector.RecycleElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.recycleelement)

## -examples
