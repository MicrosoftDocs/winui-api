---
-api-id: T:Microsoft.UI.Xaml.Controls.BackdropMaterial
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.BackdropMaterial

<!--
public class BackdropMaterial : Windows.UI.Xaml.DependencyObject
-->

## -description

Helper class to apply a backdrop material to the root of the XAML content.

## -xaml-syntax

```xaml
<Page muxc:BackdropMaterial.ApplyToRootOrPageBackground="True">
    pageContent
</Page>
-or-
<Frame muxc:BackdropMaterial.ApplyToRootOrPageBackground="True">
    appContent
</Frame>
```

## -remarks

A backdrop material is a _Material_ created from a source of pixels taken from an area behind the XAML content.

The `BackdropMaterial` class lets you apply a backdrop material, [Mica](/windows/apps/design/style/mica), to your application's composition target. It automatically supports theme changes, down-level versions, and device state, by setting a neutral-colored XAML brush when necessary.

> [!CAUTION]
> When you apply the backdrop material, do not also set the `Background` property on the UI content. The background must be transparent so the backdrop material shows through.

### XAML attached properties

`BackdropMaterial` is the host service class for the `ApplyToRootOrPageBackground` [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](/uwp/api/windows.ui.xaml.dependencyobject.getvalue(windows.ui.xaml.dependencyproperty)) or [SetValue](/uwp/api/windows.ui.xaml.dependencyobject.setvalue(windows.ui.xaml.dependencyproperty,system.object)) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| `ApplyToRootOrPageBackground` | Applies the backdrop material to the root or background of the XAML content.<ul><li>Type: Bool</li><li>Identifier field: <a href="backdropmaterial_applytorootorpagebackgroundproperty.md">ApplyToRootOrPageBackgroundProperty</a></li><li>Accessor methods: <a href="backdropmaterial_getapplytorootorpagebackground_1267516499.md">GetApplyToRootOrPageBackground</a>, <a href="backdropmaterial_setapplytorootorpagebackground_816395559.md">SetApplyToRootOrPageBackground</a></li></ul> The `ApplyToRootOrPageBackground` property is a Boolean value that indicates whether the backdrop material is applied. |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Mica](/windows/uwp/design/style/mica.md).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:) or [**WinUI 2 Gallery**](winui2gallery:).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

## -see-also

[Mica](/windows/apps/design/style/mica)
