---
-api-id: T:Microsoft.UI.Xaml.Controls.PipsPager
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.PipsPager

<!--
public class PipsPager : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control that enables navigation within linearly paginated content using a configurable collection of glyphs, each of which represents a single "page" within a limitless range.

## -remarks

The glyphs highlight the current page, and indicate the availability of both preceding and succeeding pages. The control relies on current context and does not support explicit page numbering or a non-linear organization.

See the [PipsPager overview](/windows/apps/design/controls/pipspager) for more details.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the PipsPager control.

### All Theme Resources

| Resource key | Description | Type
|:-:|:--| :-- |
| PipsPagerVerticalButtonWidth  | Sets the bounding box width for each pip when in vertical orientation | Double |
| PipsPagerVerticalButtonHeight  | Sets the bounding box height for each pip when in vertical orientation | Double |
| PipsPagerHorizontalButtonWidth  | Sets the bounding box width for each pip when in horizontal orientation | Double |
| PipsPagerHorizontalButtonHeight  | Sets the bounding box height for each pip when in horizontal orientation | Double |
| PipsPagerButtonBorderThickness | Sets the border thickness for each pip | Thickness |
| PipsPagerNavigationButtonBorderThickness | Sets the border thickness for each navigational button | Thickness |
| PipsPagerSelectedGlyph | Sets the pip glyph when selected in MDL2 icon set | String |
| PipsPagerNormalGlyph | Sets the default pip glyph in MDL2 icon set | String |
| PipsPagerNavigationButtonHeight | Sets the height for each navigational button | Double |
| PipsPagerNavigationWidth | Sets the width for each navigational button | Double |
| PipsPagerNavigationButtonFontSize | Sets the font size for each navigational button | Double |
| PipsPagerSelectedGlyphFontSize | Sets the size in pixels of the pip glyph when selected | Double |
| PipsPagerNormalGlyphFontSize | Sets the size in pixels of the pip glyph at rest| Double |
| PipsPagerSelectionIndicatorBackground | Sets the pip background | StaticResource |
| PipsPagerSelectionIndicatorBackgroundPointerOver | Sets the pip background on pointer over | StaticResource |
| PipsPagerSelectionIndicatorBackgroundPressed | Sets the pip background when pressed| StaticResource |
| PipsPagerSelectionIndicatorBackgroundSelected | Sets the pip background when selected | StaticResource |
| PipsPagerSelectionIndicatorBackgroundDisabled | Sets the pip background when disabled | StaticResource |
| PipsPagerSelectionIndicatorBorderBrush | Sets the pip border | StaticResource |
| PipsPagerSelectionIndicatorBorderBrushPointerOver | Sets the pip border on pointer over | StaticResource |
| PipsPagerSelectionIndicatorBorderBrushPressed | Sets the pip border when pressed | StaticResource |
| PipsPagerSelectionIndicatorBorderBrushSelected | Sets the pip border when selected | StaticResource |
| PipsPagerSelectionIndicatorBorderBrushDisabled | Sets the pip border when disabled | StaticResource |
| PipsPagerSelectionIndicatorForeground | Sets the pip foreground | StaticResource |
| PipsPagerSelectionIndicatorForegroundPointerOver | Sets the pip foreground on pointer over | StaticResource |
| PipsPagerSelectionIndicatorForegroundPressed | Sets the pip foreground when pressed | StaticResource |
| PipsPagerSelectionIndicatorForegroundSelected | Sets the pip foreground when selected | StaticResource |
| PipsPagerSelectionIndicatorForegroundDisabled | Sets the pip foreground when disabled | StaticResource |
| PipsPagerNavigationButtonBackground | Sets the navigation button background | StaticResource |
| PipsPagerNavigationButtonBackgroundPointerOver | Sets the navigation button background on pointer over | StaticResource |
| PipsPagerNavigationButtonBackgroundPressed | Sets the navigation button background when pressed | StaticResource |
| PipsPagerNavigationButtonBackgroundDisabled | Sets the navigation button background when disabled | StaticResource |
| PipsPagerNavigationButtonBorderBrush | Sets the navigation button border | StaticResource |
| PipsPagerNavigationButtonBorderBrushPointerOver | Sets the navigation button border on pointer over | StaticResource |
| PipsPagerNavigationButtonBorderBrushPressed | Sets the navigation button border when pressed | StaticResource |
| PipsPagerNavigationButtonBorderBrushDisabled | Sets the navigation button border when disabled | StaticResource |
| PipsPagerNavigationButtonForeground | Sets the navigation button foreground | StaticResource |
| PipsPagerNavigationButtonForegroundPointerOver | Sets the navigation button foreground on pointer over | StaticResource |
| PipsPagerNavigationButtonForegroundPressed | Sets the navigation button foreground when pressed | StaticResource |
| PipsPagerNavigationButtonForegroundDisabled | Sets the navigation button foreground when disabled | StaticResource |

## -see-also

[PipsPager overview](/windows/apps/design/controls/pipspager)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [PipsPager](/windows/apps/design/controls/pipspager).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/PipsPager) or [**WinUI 2 Gallery**](winui2gallery:/item/PipsPager).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

