---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter

<!--
public sealed class CornerRadiusFilterConverter : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Data.IValueConverter
-->

## -description

Converts an existing CornerRadius struct to a new CornerRadius struct, with filters applied to extract only the specified fields, leaving the others set to 0.

## -remarks

Use the CornerRadiusFilterConverter with a Binding or TemplateBinding to create a new CornerRadius struct from an existing one, extracting only some of the fields, leaving the others set to 0.

## -see-also

[IValueConverter](/uwp/api/windows.ui.xaml.data.ivalueconverter)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Corner radius](/windows/apps/design/style/rounded-corner).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:) or [**WinUI 2 Gallery**](winui2gallery:).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/p/winui-3-controls-gallery/9p3jfpwwdzrc) and the [**WinUI 2 Gallery**](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).



The following example shows how to use the CornerRadiusFilterConverter element.

```xaml
<ControlTemplate TargetType="Button">
    <Grid>
        <Grid.Resources>
            <CornerRadiusFilterConverter Filter="Top" x:Name="TopCornersFilter" />
        </Grid.Resources>
        <Border Background="{TemplateBinding Background}"
                CornerRadius="{Binding  CornerRadius,
                RelativeSource={RelativeSource TemplatedParent},
                Converter={StaticResource TopCornersFilter}}"
                Padding="{TemplateBinding Padding}">
            <ContentPresenter />
        </Border>
    </Grid>
</ControlTemplate>
```
