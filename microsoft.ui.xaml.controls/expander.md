---
-api-id: T:Microsoft.UI.Xaml.Controls.Expander
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.Expander

<!--
public class Expander : Windows.UI.Xaml.Controls.ContentControl
-->

## -description

::: moniker range="winui-3.0-preview"
> [!CAUTION]
> This API is in development and considered experimental in the WinUI version selected. It might be altered or unavailable in other versions.
::: moniker-end

Represents a control that displays a header and has a collapsible body that displays content.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Expander overview](/windows/apps/design/controls/expander).

Use an `Expander` to focus on the most important content when display space is limited. The `Expander` control lets you show or hide less important content that's related to a piece of primary content that's always visible. Items contained in the [Header](/uwp/api/microsoft.ui.xaml.controls.expander.header) are always visible. The user can expand and collapse the [Content](/uwp/api/microsoft.ui.xaml.controls.expander.content) area, where secondary content is displayed, by interacting with the header. When the content area is expanded, it pushes other UI elements out of the way; it does not overlay other UI. The `Expander` can expand upwards or downwards.

Both the `Header` and `Content` areas can contain any content, from simple text to complex UI layouts.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the Expander control.

| Resource key | Description |
|:-:|:--|
| ExpanderHeaderBackground | Header background color |
| ExpanderHeaderForeground | Header foreground color at rest |
| ExpanderHeaderForegroundPointerOver | Header foreground color on pointer over |
| ExpanderHeaderForegroundPressed | Header foreground color when pressed |
| ExpanderHeaderBorderBrush | Header border color at rest |
| ExpanderHeaderBorderPointerOverBrush | Header border color on pointer over |
| ExpanderHeaderBorderPressedBrush | Header border color when pressed |
| ExpanderHeaderDisabledForeground | Header foreground color when disabled |
| ExpanderHeaderDisabledBorderBrush | Header border color when disabled |
| ExpanderHeaderBorderThickness| Header border thickness |
| ExpanderChevronBackground | Chevron background color at rest |
| ExpanderChevronPointerOverBackground | Chevron background color on pointer over |
| ExpanderChevronPressedBackground | Chevron background color when pressed |
| ExpanderChevronForeground | Chevron foreground color at rest |
| ExpanderChevronPointerOverForeground | Chevron foreground color on pointer over |
| ExpanderChevronPressedForeground | Chevron foreground color when pressed |
| ExpanderChevronBorderBrush | Chevron border color at rest |
| ExpanderChevronBorderPointerOverBrush | Chevron border color on pointer over |
| ExpanderChevronBorderPressedBrush | Chevron border color when pressed |
| ExpanderChevronBorderThickness | Chevron border thickness |
| ExpanderContentBackground | Content background color |
| ExpanderContentBorderBrush | Content border color |
| ExpanderMinHeight | Minimum height of Expander |
| ExpanderHeaderHorizontalContentAlignment | Horizontal alignment of content |
| ExpanderHeaderVerticalContentAlignment | Vertical alignment of content |
| ExpanderHeaderPadding| Header padding thickness |
| ExpanderChevronMargin| Chevron margin thickness |
| ExpanderChevronUpGlyph| Chevron glyph when [ExpandDirection](expander_expanddirection.md) is Up |
| ExpanderChevronDownGlyph| Chevron glyph when [ExpandDirection](expander_expanddirection.md) is Down |
| ExpanderChevronButtonSize| Chevron button size |
| ExpanderChevronGlyphSize| Chevron glyph size |
| ExpanderContentPadding| Content padding thickness |
| ExpanderContentDownBorderThickness| Content border thickness when [ExpandDirection](expander_expanddirection.md) is Down |
| ExpanderContentUpBorderThickness| Content border thickness when [ExpandDirection](expander_expanddirection.md) is Up |
| ExpanderHeaderDownStyle| Header style when [ExpandDirection](expander_expanddirection.md) is Down |
| ExpanderHeaderUpStyle| Header style when [ExpandDirection](expander_expanddirection.md) is Up |

## -see-also

[Expander overview](/windows/apps/design/controls/expander)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Expander](/windows/apps/design/controls/expander).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/Expander) or [**WinUI 2 Gallery**](winui2gallery:/item/Expander).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).
