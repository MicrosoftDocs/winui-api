---
-api-id: T:Microsoft.UI.Xaml.Controls.InfoBar
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.InfoBar

<!--
public class InfoBar : Windows.UI.Xaml.Controls.Control
-->


## -description

An `InfoBar` is an inline notification for essential app-wide messages. The `InfoBar` will take up space in a layout and will not cover up other content or float on top of it. It supports rich content (including titles, messages, icons, and buttons) and can be configured to be user-dismissable or persistent.

## -remarks

Use an `InfoBar` control when a user should be informed of, acknowledge, or take action on a changed application state. The changed state should impact app perception or experience for the user.  

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the InfoBar control.

### All Theme Resources
| Resource Key | Description |
|:-:|:--|
| InfoBarErrorSeverityBackgroundBrush | Error Severity background color 
| InfoBarWarningSeverityBackgroundBrush | Warning Severity background color 
| InfoBarSuccessSeverityBackgroundBrush | Success Severity background color 
| InfoBarInformationalSeverityBackgroundBrush | Informational Severity background color
| InfoBarErrorSeverityIconBackground | Error Severity icon background color
| InfoBarWarningSeverityIconBackground | Warning Severity icon background color
| InfoBarSuccessSeverityIconBackground | Success Severity icon background color
| InfoBarInformationalSeverityIconBackground | Informational Severity icon background color
| InfoBarErrorSeverityIconForeground | Error Severity icon foreground color
| InfoBarWarningSeverityIconForeground | Warning Severity foreground icon color
| InfoBarSuccessSeverityIconForeground | Success Severity foreground icon color
| InfoBarInformationalSeverityIconForeground | Informational Severity foreground icon color
| InfoBarTitleForeground | Title text color
| InfoBarMessageForeground | Message text color 
| InfoBarHyperlinkButtonForeground | Hyperlink button text color
| InfoBarBorderBrush | Border color
| InfoBarBorderThickness | Border thickness
| InfoBarTitleFontSize | Title text font size 
| InfoBarTitleFontWeight | Title text font weight
| InfoBarMessageFontSize | Message text font size
| InfoBarMessageFontWeight | Message text font weight
| InfoBarMinHeight | Minimum height of InfoBar
| InfoBarCloseButtonSize | Close button size
| InfoBarCloseButtonGlyphSize | Close button glyph size
| InfoBarHyperlinkButtonMargin | Hyperlink button margin thickness
| InfoBarIconBackgroundGlyph | Background glyph behind each default icon
| InfoBarInformationalIconGlyph | Informational Severity icon glyph
| InfoBarErrorIconGlyph | Error Severity icon glyph
| InfoBarWarningIconGlyph | Warning Severity icon glyph
| InfoBarSuccessIconGlyph | Success Severity icon glyph
| InfoBarContentRootPadding | Padding thickness for Content property
| InfoBarIconMargin | Icon margin thickness
| InfoBarIconFontSize | Icon font size
| InfoBarPanelMargin | Panel margin thickness
| InfoBarPanelHorizontalOrientationPadding | Panel padding in horizontal, single-line layout
| InfoBarPanelVerticalOrientationPadding | Panel padding in vertical, multiline layout
| InfoBarTitleHorizontalOrientationMargin | Title margin thickness in the horizontal, single-line layout
| InfoBarTitleVerticalOrientationMargin | Title margin thickness in the vertical, multiline layout
| InfoBarMessageHorizontalOrientationMargin | Message margin thickness in the horizontal, single-line layout
| InfoBarMessageVerticalOrientationMargin | Message margin thickness in the vertical, multiline layout
| InfoBarActionHorizontalOrientationMargin | Action content margin thickness in the horizontal, single-line layout
| InfoBarActionVerticalOrientationMargin | Action content margin thickness in the vertical, multiline layout
| InfoBarCloseButtonSymbol | Close button symbol glyph
| InfoBarCloseButtonStyle | Close button style

## -see-also

[InfoBar overview](/windows/apps/design/controls/infobar)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [InfoBar](/windows/apps/design/controls/infobar).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/InfoBar) or [**WinUI 2 Gallery**](winui2gallery:/item/InfoBar).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).
