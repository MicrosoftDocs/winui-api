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

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

Use the CornerRadiusFilterConverter with a Binding or TemplateBinding to create a new CornerRadius struct from an existing one, extracting only some of the fields, leaving the others set to 0.

## -see-also

[IValueConverter](/uwp/api/windows.ui.xaml.data.ivalueconverter)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, [open the app to see the controls in action](xamlcontrolsgallery:).

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).

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
