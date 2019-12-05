---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter
-api-type: winrt class
---

## -description

Converts an existing CornerRadius struct to a new CornerRadius struct, with filters applied to extract only the specified fields, leaving the others set to 0.

## -remarks

Use the CornerRadiusFilterConverter with a Binding or TemplateBinding to create a new CornerRadius struct from an existing one, extracting only some of the fields, leaving the others set to 0.

## -see-also

[IValueConverter](/uwp/api/windows.ui.xaml.data.ivalueconverter)

## -examples

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
