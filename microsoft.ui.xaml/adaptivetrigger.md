---
-api-id: T:Microsoft.UI.Xaml.AdaptiveTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class AdaptiveTrigger : Windows.UI.Xaml.StateTriggerBase, Windows.UI.Xaml.IAdaptiveTrigger
-->

# Microsoft.UI.Xaml.AdaptiveTrigger

## -description
Represents a declarative rule that applies visual states based on window properties.

## -xaml-syntax
```xaml
<AdaptiveTrigger .../>
```


## -remarks
Use AdaptiveTriggers to create rules that automatically trigger a [VisualState](visualstate.md) change when the window is a specified height or width. When you use AdaptiveTriggers in your XAML markup, you don't need to handle the [Window.SizeChanged](window_sizechanged.md) event and call [VisualStateManager.GoToState](visualstatemanager_gotostate_51722231.md) in your code. Also, when you use AdaptiveTriggers in your [VisualStateManager](visualstatemanager.md), you can see the effects of these adaptive changes directly on the XAML design surface in Microsoft Visual Studio.

You can use the [MinWindowWidth](adaptivetrigger_minwindowwidth.md) and [MinWindowHeight](adaptivetrigger_minwindowheight.md) properties either independently or in conjunction with each other. This XAML shows an example of using both properties together. The trigger indicates that the corresponding [VisualState](visualstate.md) is to be applied when the current window width is &gt;= 720 effective pixels AND the current window height is &gt;= 900 effective pixels.



```xaml
<AdaptiveTrigger MinWindowWidth="720" MinWindowHeight="900"/>
```

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Responsive layouts with XAML](/windows/apps/design/layout/layouts-with-xaml).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:) or [**WinUI 2 Gallery**](winui2gallery:).
>
> If they are not installed, you can get the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also view, clone, and build both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

The following example shows how to use the [StateTriggers](visualstate_statetriggers.md) property with an AdaptiveTrigger to create a declarative rule in XAML markup based on window size. By default, the [StackPanel](../microsoft.ui.xaml.controls/stackpanel.md) orientation is **Vertical**. When the window width is &gt;= 720 effective pixels, the [VisualState](visualstate.md) change is triggered, and the [StackPanel](../microsoft.ui.xaml.controls/stackpanel.md) orientation is changed to **Horizontal**.

```xaml
<Page>
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup>
                <VisualState>
                    <VisualState.StateTriggers>
                    <!--VisualState to be triggered when window width is >=720 effective pixels.-->
                        <AdaptiveTrigger MinWindowWidth="720"/>
                    </VisualState.StateTriggers>

                    <VisualState.Setters>
                        <Setter Target="myPanel.Orientation" Value="Horizontal"/>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateManager.VisualStateGroups>
        <StackPanel x:Name="myPanel" Orientation="Vertical">
            <TextBlock Text="This is a block of text. It is text block 1. " 
                       Style="{ThemeResource BodyTextBlockStyle}"/>
            <TextBlock Text="This is a block of text. It is text block 2. " 
                       Style="{ThemeResource BodyTextBlockStyle}"/>
            <TextBlock Text="This is a block of text. It is text block 3. " 
                       Style="{ThemeResource BodyTextBlockStyle}"/>
        </StackPanel>
    </Grid>
</Page>

```

## -see-also
[StateTriggerBase](statetriggerbase.md), [VisualState](visualstate.md), [VisualState.StateTriggers](visualstate_statetriggers.md)
