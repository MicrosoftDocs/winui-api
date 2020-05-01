---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate

<!--
public object ItemTemplate { get; set; }
-->

## -description

Gets or sets the template used to display each item.

## -property-value

The template that specifies the visualization of the data objects. The default is **null**.

## -remarks

Set this property to a factory object used to generate a UIElement for a given data item. This can be a [DataTemplate](/uwp/api/windows.ui.xaml.datatemplate), a [DataTemplateSelector](/uwp/api/windows.ui.xaml.controls.datatemplateselector), a [RecyclingElementFactory](recyclingelementfactory.md), or a custom implementation of [IElementFactory](/uwp/api/windows.ui.xaml.ielementfactory) that creates UIElements by some other mechanism, like [XamlDirect](../microsoft.ui.xaml.core.direct/xamldirect.md).

> [!IMPORTANT]
> When running on Windows 10, version 1809 or later, this can be any object that supports IElementFactory. On earlier versions of Windows 10, this must be a DataTemplate or DataTemplateSelector.

Generated elements might be re-used. For example, an element generated to display the item at index 0 might be reused later to display the item at index 100.

## -see-also

## -examples

