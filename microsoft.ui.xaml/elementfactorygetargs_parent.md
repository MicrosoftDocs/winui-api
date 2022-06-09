---
-api-id: P:Microsoft.UI.Xaml.ElementFactoryGetArgs.Parent
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Parent { get;  set; }
-->

# Microsoft.UI.Xaml.ElementFactoryGetArgs.Parent

## -description

Gets or sets the [UIElement](uielement.md) that is expected to be the parent of the realized element from [GetElement](ielementfactory_getelement_445960756.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The [UIElement](uielement.md) object expected to be the parent of the realized [UIElement](uielement.md) or **null**.  By default, it is **null**.

## -remarks

This value is optional. When used it can enable a performance optimization for implementations of [GetElement](ielementfactory_getelement_445960756.md) that return recycled elements. For more info, see the remarks for the [DataTemplate.RecycleElement](datatemplate_recycleelement_1220951169.md) method.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](/uwp/api/windows.ui.xaml.datatemplate.getelement), [DataTemplate.RecycleElement](/uwp/api/windows.ui.xaml.datatemplate.recycleelement), [DataTemplateSelector.GetElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.getelement), [DataTemplateSelector.RecycleElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.recycleelement), [ElementFactoryGetArgs](elementfactorygetargs.md), [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md)

## -examples

