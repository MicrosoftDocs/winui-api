---
-api-id: T:Microsoft.UI.Xaml.Controls.FontIcon
-api-type: winrt class
---

<!-- Class syntax.
public class FontIcon : Windows.UI.Xaml.Controls.IconElement, Windows.UI.Xaml.Controls.IFontIcon, Windows.UI.Xaml.Controls.IFontIcon2, Windows.UI.Xaml.Controls.IFontIcon3
-->

# Microsoft.UI.Xaml.Controls.FontIcon

## -description

Represents an icon that uses a glyph from the specified font.

## -xaml-syntax

```xaml
<FontIcon .../>
```

## -remarks

Use `FontIcon` to specify an icon using a [Glyph](fonticon_glyph.md) value from a [FontFamily](fonticon_fontfamily.md). Glyph values are assigned by font developers to private Unicode values that don't map to existing code points.

### Default font family

If you don't specify a `FontFamily`, or you specify a `FontFamily` that is not available on the system at runtime, the `FontIcon` falls back to the default font family defined by the `SymbolThemeFontFamily` theme resource.

By default, Windows uses the [**Segoe Fluent Icon**](/windows/apps/design/style/segoe-ui-symbol-font) font family. If your app is run on Windows 10, version 20H2 or earlier, the Segoe Fluent Icon font family is not available and the `SymbolThemeFontFamily` resource falls back to the [**Segoe MDL2 Asset**](/windows/apps/design/style/segoe-ui-symbol-font) font family instead. To use glyphs from the default system font, don't set the `FontFamily` property, let it use its default value.

> [!TIP]
> Many common glyphs from the `SymbolThemeFontFamily` are included in the [Symbol](symbol.md) enumeration. If the glyph you need is available as a `Symbol`, you can use a [SymbolIcon](symbolicon.md) anywhere you would use a `FontIcon` with the default font family.

### Mirroring

You can set the [MirroredWhenRightToLeft](fonticon_mirroredwhenrighttoleft.md) property to have the glyph appear mirrored when the [FlowDirection](../microsoft.ui.xaml/frameworkelement_flowdirection.md) is [RightToLeft](../microsoft.ui.xaml/flowdirection.md). You typically use this property when a FontIcon is used to display an icon as part of a control template and the icon needs to be mirrored along with the rest of the control.

### Foreground

If you use a `FontIcon` in an [AppBarButton](appbarbutton.md), you can set the `Foreground` property on the `AppBarButton` or on the `FontIcon`. If you set the [Foreground](control_foreground.md) on the `AppBarButton`, it's applied only to the default visual state. It's not applied to the other visual states defined in the `AppBarButton` template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the `FontIcon`, the color is applied to all visual states.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/AppBarButton) or [**WinUI 2 Gallery**](winui2gallery:/item/AppBarButton).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

This example shows an [AppBarToggleButton](appbartogglebutton.md) with a `FontIcon`.

```xaml
<AppBarToggleButton Label="FontIcon">
    <AppBarToggleButton.Icon>
        <FontIcon FontFamily="Segoe UI Emoji" Glyph="&#x25B6;"/>
    </AppBarToggleButton.Icon>
</AppBarToggleButton>
```

Here's how to create the same button in code.

```csharp
var newAppBarButton = new AppBarButton();
newAppBarButton.Label = "FontIcon";
var fontIcon = new FontIcon();
fontIcon.FontFamily = new FontFamily("Segoe UI Emoji");
fontIcon.Glyph = "\x25B6";
newAppBarButton.Icon = fontIcon;
```

```cppwinrt
using namespace winrt::Windows::UI::Xaml;
...

auto newAppBarButton = Controls::AppBarButton{};
newAppBarButton.Label(L"FontIcon");
auto fontIcon = Controls::FontIcon{};
fontIcon.FontFamily(Media::FontFamily{ L"Segoe UI Emoji" });
fontIcon.Glyph(L"\x25B6");
newAppBarButton.Icon(fontIcon);
```

## -see-also
[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [SymbolIcon](symbolicon.md), [Icons for Windows apps](/windows/apps/design/style/icons)
