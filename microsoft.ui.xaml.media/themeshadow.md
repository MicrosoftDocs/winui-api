---
-api-id: T:Microsoft.UI.Xaml.Media.ThemeShadow
-api-type: winrt class
---

<!-- Class syntax.
public class ThemeShadow : Shadow, Shadow
-->

# Microsoft.UI.Xaml.Media.ThemeShadow

## -description

A ThemeShadow is a preconfigured shadow effect that can be applied to any XAML element to draw shadows appropriately based on x, y, z coordinates. ThemeShadow also automatically adjusts for other environmental specifications:

- Adapts to changes in lighting, user theme, app environment, and shell.
- Shadows elements automatically based on their elevation.
- Keeps elements in sync as they move and change elevation.
- Keeps shadows consistent throughout and across applications.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/apps/design/layout/depth-shadow).

A ThemeShadow can be applied to any XAML element to draw shadows based on the relative x, y, and z coordinates between a conceptual caster UIElement and one or more receiver UIElements which have the caster's shadow rendered onto them. 

ThemeShadow supports only rectangular shadows. For custom shadow effects, you can use a [DropShadow](../microsoft.ui.composition/dropshadow.md).

### ThemeShadows in Popups

ThemeShadow automatically casts shadows when applied to any XAML element in a [Popup](../microsoft.ui.xaml.controls.primitives/popup.md). It will cast shadows on the app background content behind it and any other open Popups below it.

To use ThemeShadow with Popups, use the [UIElement.Shadow](../microsoft.ui.xaml/uielement_shadow.md) property to apply a ThemeShadow to a XAML element. Then, elevate the element from other elements behind it, for example by using the z component of the [UIElement.Translation](../microsoft.ui.xaml/uielement_translation.md) property.
For most Popup UI, the recommended default elevation relative to the app background content is 32 effective pixels.

### ThemeShadow in other elements

To cast a shadow from a XAML element that isn't in a [Popup](../microsoft.ui.xaml.controls.primitives/popup.md), you must explicitly specify the other elements that can receive the shadow in the [ThemeShadow.Receivers](themeshadow_receivers.md) collection. Receivers cannot be an ancestor of the caster in the visual tree.

### Performance best practices for ThemeShadow

1. Limit the number of custom receiver elements to the minimum necessary.

2. If multiple receiver elements are at the same elevation then try to combine them by targeting a single parent element instead.

3. If multiple elements will cast the same type of shadow onto the same receiver elements then add the shadow as a shared resource and reuse it.

## -see-also

[Z-depth and shadow](/windows/apps/design/layout/depth-shadow), [UIElement.Shadow](../microsoft.ui.xaml/uielement_shadow.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/apps/design/layout/depth-shadow).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:) or [**WinUI 2 Gallery**](winui2gallery:).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).
