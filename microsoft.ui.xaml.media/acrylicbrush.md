---
-api-id: T:Microsoft.UI.Xaml.Media.AcrylicBrush
-api-type: winrt class
---
<!-- Class syntax.
public class AcrylicBrush : XamlCompositionBrushBase, XamlCompositionBrushBase
-->

# Microsoft.UI.Xaml.Media.AcrylicBrush

## -description

Paints an area with a semi-transparent material that uses multiple effects including blur and a noise texture.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

You can easily apply acrylic to your app's surfaces using predefined AcrylicBrush theme resources. First, you'll need to decide whether to use in-app or background acrylic. Be sure to review common app patterns described in the [Acrylic material](/windows/apps/design/style/acrylic) article for recommendations.

We've created a collection of brush theme resources for both background and in-app acrylic types that respect the app's theme and fall back to solid colors as needed. For WinUI 2, these theme resources are located in the [AcrylicBrush themeresources file, in the microsoft-ui-xaml GitHub repo](https://github.com/microsoft/microsoft-ui-xaml/blob/6aed8d97fdecfe9b19d70c36bd1dacd9c6add7c1/dev/Materials/Acrylic/AcrylicBrush_19h1_themeresources.xaml#L11). Resources that include *Background* in their names represent background acrylic, while *InApp* refers to in-app acrylic.

To paint a specific surface, apply one of the WinUI 2 theme resources to element backgrounds just as you would apply any other brush resource.

```xaml
<Grid Background="{ThemeResource AcrylicBackgroundFillColorDefaultBrush}">
```

## -see-also

[AcrylicBackgroundSource](acrylicbackgroundsource.md), [Acrylic material overview](/windows/apps/design/style/acrylic)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Acrylic material](/windows/apps/design/style/acrylic).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/Acrylic) or [**WinUI 2 Gallery**](winui2gallery:/item/Acrylic).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

To add an acrylic brush, define the three resources for dark, light, and high contrast themes. Note that in high contrast, we recommend using a SolidColorBrush with the same `x:Key` as the dark/light AcrylicBrush.

> [!NOTE]
> If you don't specify a TintLuminosityOpacity value, the system will automatically adjust its value based on your TintColor and TintOpacity.

```xaml
<ResourceDictionary.ThemeDictionaries>
    <ResourceDictionary x:Key="Default">
        <AcrylicBrush x:Key="MyAcrylicBrush"
            BackgroundSource="HostBackdrop"
            TintColor="#FFFF0000"
            TintOpacity="0.8"
            TintLuminosityOpacity="0.5"
            FallbackColor="#FF7F0000"/>
    </ResourceDictionary>

    <ResourceDictionary x:Key="HighContrast">
        <SolidColorBrush x:Key="MyAcrylicBrush"
            Color="{ThemeResource SystemColorWindowColor}"/>
    </ResourceDictionary>

    <ResourceDictionary x:Key="Light">
        <AcrylicBrush x:Key="MyAcrylicBrush"
            BackgroundSource="HostBackdrop"
            TintColor="#FFFF0000"
            TintOpacity="0.8"
            TintLuminosityOpacity="0.5"
            FallbackColor="#FFFF7F7F"/>
    </ResourceDictionary>
</ResourceDictionary.ThemeDictionaries>
```

This example shows how to create an AcrylicBrush in code.

```csharp
Microsoft.UI.Xaml.Media.AcrylicBrush myBrush = new Microsoft.UI.Xaml.Media.AcrylicBrush();
myBrush.BackgroundSource = Microsoft.UI.Xaml.Media.AcrylicBackgroundSource.HostBackdrop;
myBrush.TintColor = Color.FromArgb(255, 202, 24, 37);
myBrush.FallbackColor = Color.FromArgb(255, 202, 24, 37);
myBrush.TintOpacity = 0.6;

grid.Fill = myBrush;
```
