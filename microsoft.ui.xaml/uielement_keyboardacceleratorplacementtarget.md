---
-api-id: P:Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject KeyboardAcceleratorPlacementTarget { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget

## -description

Gets or sets a value that indicates the control [tooltip](../microsoft.ui.xaml.controls/tooltip.md) that displays the accelerator key combination.

## -property-value

The control tooltip that displays the accelerator key combination.

## -remarks

Use the [KeyboardAcceleratorPlacementMode](uielement_keyboardacceleratorplacementmode.md) property to specify whether the control tooltip displays the key combination for it's associated keyboard accelerator.

## -examples

```xaml
<Grid x:Name="Container">

    <Button Content="Click" 
        ToolTipService.ToolTip="Tooltip"
        ToolTipService.PlacementTarget="{x:Bind Container}" 
        KeyboardAcceleratorPlacementTarget="{x:Bind Container}">
        <Button.KeyboardAccelerators>
            <KeyboardAccelerator Key="S" Modifiers="Control"/>
        </Button.KeyboardAccelerators>
    </Button>

</Grid>
```

In some cases, you might need to present a tooltip relative to another element (typically a container object).

Here, we show how to use the KeyboardAcceleratorPlacementTarget property to display the keyboard accelerator key combination for a Save button with the Grid container instead of the button.

```xaml
<Grid x:Name="Container">

  <Button Content="Save" Click="OnSave">
    <Button.KeyboardAccelerators>
      <KeyboardAccelerator  Key="S" Modifiers="Control" 
        KeyboardAcceleratorPlacementTarget="{x:Bind Container}"/>
    </Button.KeyboardAccelerators>
  </Button>

</Grid>
```

## -see-also

[Keyboard Accelerators](/windows/apps/design/input/keyboard-accelerators)
