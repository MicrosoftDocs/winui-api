---
-api-id: T:Microsoft.UI.Xaml.Controls.Slider
-api-type: winrt class
---

<!-- Class syntax.
public class Slider : Windows.UI.Xaml.Controls.Primitives.RangeBase, Windows.UI.Xaml.Controls.ISlider, Windows.UI.Xaml.Controls.ISlider2
-->

# Microsoft.UI.Xaml.Controls.Slider

## -description
Represents a control that lets the user select from a range of values by moving a [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) control along a track.

## -xaml-syntax
```xaml
<Slider .../>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Sliders](/windows/apps/design/controls/slider).

Slider is a control that lets the user select from a range of values by moving a [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) control along a track.

<img alt="Slider control" src="images/controls/Slider.png" />

Use a Slider control when you want your users to be able to set defined, contiguous values (such as volume or brightness) or a range of discrete values (such as screen resolution settings). Sliders are for user interaction. If a user can't ever change the value, use read-only text instead. For more information on when to use a Slider, see [Guidelines for sliders](/windows/uwp/controls-and-patterns/slider).

### Binding Minimum and Maximum values

When binding [Minimum](../microsoft.ui.xaml.controls.primitives/rangebase_minimum.md) and [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) values in Extensible Application Markup Language (XAML), declare the [Binding](../microsoft.ui.xaml.data/binding.md) for [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) first. If the [Binding](../microsoft.ui.xaml.data/binding.md) for [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) is declared after [Minimum](../microsoft.ui.xaml.controls.primitives/rangebase_minimum.md), the bound value for [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) is ignored and the following situations can occur: 

+ If the bound [Minimum](../microsoft.ui.xaml.controls.primitives/rangebase_minimum.md) value is negative, the [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) value is set to 0.
+ If the bound [Minimum](../microsoft.ui.xaml.controls.primitives/rangebase_minimum.md) value is greater than the default [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) (100 for Slider and [ProgressBar](progressbar.md)), the [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) value is set equal to the [Minimum](../microsoft.ui.xaml.controls.primitives/rangebase_minimum.md) value.

To avoid this behavior, declare the [Binding](../microsoft.ui.xaml.data/binding.md) for [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) first in your Extensible Application Markup Language (XAML).

These behaviors can also occur if you set the [Minimum](../microsoft.ui.xaml.controls.primitives/rangebase_minimum.md) value without also explicitly setting the [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) value.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. To change certain aspects of the slider’s appearance, such as the [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) color, you need to retemplate the control (or use the resources in the table below on Windows 10, version 1607 or later). For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the Slider control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>SliderContainerBackground</td><td>Background color at rest</td></tr>
   <tr><td>SliderContainerBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>SliderContainerBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>SliderContainerBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>SliderThumbBackground</td><td>Background color of the thumb at rest</td></tr>
   <tr><td>SliderThumbBackgroundPointerOver</td><td>Background color of the thumb on hover</td></tr>
   <tr><td>SliderThumbBackgroundPressed</td><td>Background color of the thumb when pressed</td></tr>
   <tr><td>SliderThumbBackgroundDisabled</td><td>Background color of the thumb when disabled</td></tr>
   <tr><td>SliderTrackFill</td><td>Color of unfilled portion of track</td></tr>
   <tr><td>SliderTrackFillPointerOver</td><td>Color of unfilled portion of track on hover</td></tr>
   <tr><td>SliderTrackFillPressed</td><td>Color of unfilled portion of track when pressed</td></tr>
   <tr><td>SliderTrackFillDisabled</td><td>Color of unfilled portion of track when disabled</td></tr>
   <tr><td>SliderTrackValueFill</td><td>Color of filled portion of track</td></tr>
   <tr><td>SliderTrackValueFillPointerOver</td><td>Color of filled portion of track on hover</td></tr>
   <tr><td>SliderTrackValueFillPressed</td><td>Color of filled portion of track when pressed</td></tr>
   <tr><td>SliderTrackValueFillDisabled</td><td>Color of filled portion of track when disabled</td></tr>
   <tr><td>SliderHeaderForeground</td><td>Foreground color of the label</td></tr>
   <tr><td>SliderHeaderForegroundDisabled</td><td>Foreground color of the label when disabled</td></tr>
   <tr><td>SliderTickBarFill</td><td>Color of the tick marks</td></tr>
   <tr><td>SliderTickBarFillDisabled</td><td>Color of the tick marks when disabled</td></tr>
   <tr><td>SliderInlineTickBarFill</td><td>Color of inline tick marks</td></tr>
</table>

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Sliders](/windows/apps/design/controls/slider).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/Slider) or [**WinUI 2 Gallery**](winui2gallery:/item/Slider).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


The following code example shows several slider controls and how to handle the [ValueChanged](../microsoft.ui.xaml.controls.primitives/rangebase_valuechanged.md) event. The [ValueChanged](../microsoft.ui.xaml.controls.primitives/rangebase_valuechanged.md) event is used to update the value of a [TextBlock](textblock.md) as the [Value](../microsoft.ui.xaml.controls.primitives/rangebase_value.md) property of the slider changes.



[!code-xaml[1](../microsoft.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/csharp/Page.xaml#Snippet1)]

[!code-csharp[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/vbnet/Page.xaml.vb#Snippet11)]

## -see-also
[Sliders overview](/windows/uwp/controls-and-patterns/slider), [Slider styles and templates](/windows/apps/design/style/xaml-styles), [RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md), [ComboBox](combobox.md), [ListBox](listbox.md), [Controls list](/windows/apps/design/controls/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
