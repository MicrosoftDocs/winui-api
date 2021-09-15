---
-api-id: P:Microsoft.UI.Xaml.Controls.ColorPicker.Orientation
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ColorPicker.Orientation

<!--
public Windows.UI.Xaml.Controls.Orientation Orientation { get; set; }
-->


## -description

Gets or sets the orientation of the editing controls in the [ColorPicker](colorpicker.md).

## -property-value

The orientation of the editing controls in the ColorPicker. The default is [Vertical](orientation.md).

## -remarks

When the `Orientation` property is set to `Horizontal`, the ColorPicker will **not** apply the [IsMoreButtonEnabled](colorpicker_ismorebuttonvisible.md) property. Instead, the text input fields will always be displayed to the side of the ColorPicker.

### Horizontal Orientation Text Input Margin
When in `Horizontal` mode and the text input fields are in use, there will be a margin of `122px` to the right of the text input fields. This margin accounts for the different localizations of the labels of the fields and ensures that those labels will not be cut off. This margin is determined by the `ColorPickerTextInputHorizontalOrientationMargin` lightweight styling resource.

- If your app is only available in English, you can override this resource and set the right margin to `74px` to improve the horizontal footprint of the control.
- The resource does have not have any effect when the `Orientation` is set to `Vertical`.

## -see-also

[ColorPicker](colorpicker.md), [Orientation](orientation.md), [ColorPicker overview](/windows/apps/design/controls/colorpicker)

## -examples


