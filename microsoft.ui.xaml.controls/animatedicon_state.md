---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedIcon.State
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Controls.AnimatedIcon.State

<!--
see GetState, and SetState
-->

## -description

Property that the developer sets on AnimatedIcon.

## -remarks

 You change the playback position and state of the animation by setting the [AnimatedIcon.State](animatedicon_state.md) attached property. The state property takes a string value that describes the visual state, such as "`Normal`", "`PointerOver`", or "`Pressed`". You can also specify a specific state transition, such as "`PressedToNormal`".

You can set the property on the `AnimatedIcon` or on an ancestor in the XAML tree. In either case, you need to use the attached property syntax: `<muxc:AnimatedIcon muxc:AnimatedIcon.State="Normal">...</muxc:AnimatedIcon>`.

> [!IMPORTANT]
> If you add an `AnimatedIcon` to the XAML tree and set the `State` property on an ancestor element, the `State` property must be set to an initial value before the animated icon is first loaded in order for the icon to animate. You typically set the initial state in XAML as shown in the Example section.

For more info, see Remarks on the [AnimatedIcon](animatedicon.md#remarks) class page.

## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedIcon](animatedicon.md)

## -examples

```xaml
<!-- 
xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
xmlns:animatedvisuals="using:Microsoft.UI.Xaml.Controls.AnimatedVisuals"
-->

<StackPanel muxc:AnimatedIcon.State="Normal" ...>
    <muxc:AnimatedIcon>
        <animatedvisuals:AnimatedBackVisualSource/>
    </muxc:AnimatedIcon>
</StackPanel>
```
