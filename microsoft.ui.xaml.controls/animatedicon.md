---
-api-id: T:Microsoft.UI.Xaml.Controls.AnimatedIcon
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.AnimatedIcon

<!--
public class AnimatedIcon : Windows.UI.Xaml.Controls.IconElement
-->

## -description

Represents an icon that displays and controls a visual that can animate in response to user interaction and visual state changes.

## -remarks

Set the [AnimatedIcon.Source](animatedicon_source.md) property to specify the animated visual for the icon. WinUI provides animated visuals for some common icons in the [Microsoft.UI.Xaml.Controls.AnimatedVisuals](/windows/winui/api/microsoft.ui.xaml.controls.animatedvisuals) namespace.

In some cases, system settings or limitations can prevent the icon from being animated.

- If the user turns off animations in their system settings, `AnimatedIcon` displays the final frame of the state transition the control was in.
- Specify a [FallbackIconSource](animatedicon_fallbackiconsource.md) to be used when animations aren't supported, such as on older versions of Windows that don't support Lottie animations.

### Custom animations

You can create custom animations to use as an animated icon in your app. Animations can be created with [Adobe AfterEffects](https://www.adobe.com/products/aftereffects.html), then you can use that output with the [Lottie-Windows](/windows/communitytoolkit/animations/lottie) library to generate a custom class that implements [IAnimatedVisualSource2](ianimatedvisualsource2.md). You can use this class as the [Source](animatedicon_source.md) for an animated icon. For more information, see [Use Lottie to create animated content for an AnimatedIcon](/windows/apps/design/controls/animated-icon#use-lottie-to-create-animated-content-for-an-animatedicon).

### Control the animated icon state

 You change the playback position and state of the animation by setting the [AnimatedIcon.State](animatedicon_state.md) attached property. The state property takes a string value that describes the visual state, such as "`Normal`", "`PointerOver`", or "`Pressed`". You can also specify a specific state transition, such as "`PressedToNormal`".

An animated icon [Source](animatedicon_source.md) contains [Markers](/windows/winui/api/microsoft.ui.xaml.controls.ianimatedvisualsource2.markers) that map a position in the animation timeline to a visual state. The string values that a `Source` supports to set the `State` attached property are defined in the `Markers` collection. For more info, see [Define AnimatedIcon markers](/windows/apps/design/controls/animated-icon#define-animatedicon-markers).

Animated visual sources that are used in control templates often have a more complex set of `Markers` that map to control states, while animated visuals for more general use often have a more simple set of `Markers` that map to pointer events.

#### Where to set state

You can set the property on the `AnimatedIcon` or on an ancestor in the XAML tree. In either case, you need to use the attached property syntax, like this:

```xaml
<muxc:AnimatedIcon muxc:AnimatedIcon.State="Normal">...</muxc:AnimatedIcon>
```

> [!IMPORTANT]
> If you add an `AnimatedIcon` to the XAML tree and set the `State` property on an ancestor element, the `State` property must be set to an initial value before the animated icon is first loaded in order for the icon to animate. You typically set the initial state in XAML as shown here.
>
>```xaml
><StackPanel muxc:AnimatedIcon.State="Normal" ...>
>    <muxc:AnimatedIcon>
>        <animatedvisuals:AnimatedBackVisualSource/>
>    </muxc:AnimatedIcon>
></StackPanel>
>```

#### Use visual states

You can add an `AnimatedIcon` to the `ControlTemplate` of a XAML control and use a [VisualStateManager](../microsoft.ui.xaml/visualstatemanager.md) to set its state. Some controls, such as [NavigationViewItem](navigationviewitem.md), automatically set the state for an `AnimatedIcon` that is set as its [Icon](navigationviewitem_icon.md).

To see an example that sets `AnimatedIcon.State` in a control template visual state, see [CheckBox_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/CheckBox_themeresources.xaml) in the WinUI GitHub repo. The `CheckBox` control uses the [AnimatedAcceptVisualSource](../microsoft.ui.xaml.controls.animatedvisuals/animatedacceptvisualsource.md) for its check mark. The visual state setters look like this:

```xaml
<VisualState x:Name="CheckedPointerOver">
    ...
    <VisualState.Setters>
        <Setter Target="CheckGlyph.(AnimatedIcon.State)" Value="PointerOverOn"/>
    </VisualState.Setters>
</VisualState>
```

#### Handle pointer events

To make the `AnimatedIcon` respond to user interaction, you need to set the [AnimatedIcon.State](animatedicon_state.md) attached property in response to some pointer events. This table shows the pointer events you will typically handle, and common states that map to these events. (However, not every animated icon source will map to these states exactly.)

|Event  |State  |
|---------|---------|
|[PointerEntered](/uwp/api/windows.ui.xaml.uielement.pointerentered)   | "`PointerOver`" |
|[PointerPressed](/uwp/api/windows.ui.xaml.uielement.pointerpressed)   | "`Pressed`" |
|[PointerReleased](/uwp/api/windows.ui.xaml.uielement.pointerreleased) | "`Normal`" |
|[PointerExited](/uwp/api/windows.ui.xaml.uielement.pointerexited)     | "`Normal`" |

> [!TIP]
> If you place the `AnimatedIcon` inside a [Button](/uwp/api/windows.ui.xaml.controls.button) or other control that has a [Click](/uwp/api/windows.ui.xaml.controls.primitives.buttonbase.click) event, the `PointerPressed` and `PointerReleased` events are marked as [Handled](/uwp/api/windows.ui.xaml.input.pointerroutedeventargs.handled). To handle these events on a button, use the [AddHandler](/uwp/api/windows.ui.xaml.uielement.addhandler) method to connect your event handler and specify `handledEventsToo` as `true`. Use [RemoveHandler](/uwp/api/windows.ui.xaml.uielement.removehandler) to disconnect the event handler.

See the Examples section for sample code that demonstrates these event handlers.

### XAML attached properties

`AnimatedIcon` is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent *get* and *set* operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../microsoft.ui.xaml/dependencyobject_getvalue_229640130.md) or [SetValue](../microsoft.ui.xaml/dependencyobject_setvalue_1212521140.md) and passing the identifier field as the dependency property identifier.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Animated icon](/windows/apps/design/controls/animated-icon).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/AnimatedIcon) or [**WinUI 2 Gallery**](winui2gallery:/item/AnimatedIcon).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

### Add an AnimatedIcon to a button

This example demonstrates a back button that displays a back arrow icon that animates when pointer events occur.

- The [AnimatedBackVisualSource](../microsoft.ui.xaml.controls.animatedvisuals/animatedbackvisualsource.md) is a back-arrow animation provided by WinUI.
- The [FallbackIconSource](animatedicon_fallbackiconsource.md) is used when animations can't be played.
- The [AddHandler](/uwp/api/windows.ui.xaml.uielement.addhandler) method with `handledEventsToo` set to `true` is used for events that the button marks as [Handled](/uwp/api/windows.ui.xaml.input.pointerroutedeventargs.handled).

```xaml
<!-- 
xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
xmlns:animatedvisuals="using:Microsoft.UI.Xaml.Controls.AnimatedVisuals"
-->

<AppBarButton x:Name="BackButton" Label="Back"
              muxc:AnimatedIcon.State="Normal"
              PointerEntered="AppBarButton_PointerEntered"
              PointerExited="AppBarButton_PointerExited">
    <muxc:AnimatedIcon>
        <animatedvisuals:AnimatedBackVisualSource/>
        <muxc:AnimatedIcon.FallbackIconSource>
            <muxc:SymbolIconSource Symbol="Back"/>
        </muxc:AnimatedIcon.FallbackIconSource>
    </muxc:AnimatedIcon>
</AppBarButton>
```

```csharp
// using muxc = Microsoft.UI.Xaml.Controls;

// Add handlers.
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    SettingsButton.AddHandler(UIElement.PointerPressedEvent, 
        new PointerEventHandler(AppBarButton_PointerPressed), true);
    SettingsButton.AddHandler(UIElement.PointerReleasedEvent, 
        new PointerEventHandler(AppBarButton_PointerReleased), true);
    base.OnNavigatedTo(e);
}

// Remove handlers.
protected override void OnNavigatedFrom(NavigationEventArgs e)
{
    SettingsButton.RemoveHandler(UIElement.PointerPressedEvent, 
        (PointerEventHandler)AppBarButton_PointerPressed);
    SettingsButton.RemoveHandler(UIElement.PointerReleasedEvent, 
        (PointerEventHandler)AppBarButton_PointerReleased);
    base.OnNavigatedFrom(e);
}

private void AppBarButton_PointerEntered(object sender, PointerRoutedEventArgs e)
{
    muxc.AnimatedIcon.SetState((UIElement)sender, "PointerOver");
}

private void AppBarButton_PointerPressed(object sender, PointerRoutedEventArgs e)
{
    muxc.AnimatedIcon.SetState((UIElement)sender, "Pressed");
}

private void AppBarButton_PointerReleased(object sender, PointerRoutedEventArgs e)
{
    muxc.AnimatedIcon.SetState((UIElement)sender, "Normal");
}

private void AppBarButton_PointerExited(object sender, PointerRoutedEventArgs e)
{
    muxc.AnimatedIcon.SetState((UIElement)sender, "Normal");
}
```

## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedVisualPlayer](animatedvisualplayer.md), [VisualStateManager](../microsoft.ui.xaml/visualstatemanager.md), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [Interactive Segments on an Animation Timeline](/windows/communitytoolkit/animations/lottie-scenarios/segments) [IAnimatedVisual2](ianimatedvisual2.md)
