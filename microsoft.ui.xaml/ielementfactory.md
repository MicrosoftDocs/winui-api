---
-api-id: T:Microsoft.UI.Xaml.IElementFactory
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IElementFactory 
-->

# Microsoft.UI.Xaml.IElementFactory

## -description

Supports the creation and recycling of [UIElement](uielement.md) objects.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

Two concrete implementations of this interface are:

1. [DataTemplate](datatemplate.md), and
1. [DataTemplateSelector](../microsoft.ui.xaml.controls/datatemplateselector.md)

The [GetElement](ielementfactory_getelement_445960756.md) method is used to retrieve a valid instance of a [UIElement](uielement.md). The [RecycleElement](ielementfactory_recycleelement_1220951169.md) method is used to recycle elements.

## -see-also

[DataTemplate](datatemplate.md), [DataTemplateSelector](../microsoft.ui.xaml.controls/datatemplateselector.md)

## -examples

