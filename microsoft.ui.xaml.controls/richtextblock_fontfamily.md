---
-api-id: P:Microsoft.UI.Xaml.Controls.RichTextBlock.FontFamily
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.FontFamily FontFamily { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock.FontFamily

## -description
Gets or sets the preferred top-level font family for the text content in this element.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<RichTextBlock FontFamily="fontFamily" />
-or-
<RichTextBlock FontFamily="fontFamilyName[,fallbackFontFamilyName]" />
-or-
<RichTextBlock FontFamily="fontURI#fontFamily" />
```


## -xaml-values
<dl><dt>fontFamily</dt><dd>fontFamily A single font family name, for example "Verdana".</dd>
<dt>
              fontFamilyName [,fallbackFontFamilyName]</dt><dd>fontFamilyName [,fallbackFontFamilyName] A primary font family choice then one or more fallback font family choices, for example "Arial Unicode MS, Arial".</dd>
<dt>fontURI#fontFamily</dt><dd>fontURI#fontFamily Used for non-default fonts. Specifies the resource location in the assembly for a font file, and a font family within that font. For information on this usage, see FontFamily.</dd>
</dl>
## -property-value
A [FontFamily](../microsoft.ui.xaml.media/fontfamily.md) object that specifies the preferred font family, or a primary preferred font family with one or more fallback font families. For information about defaults, see the [FontFamily](../microsoft.ui.xaml.media/fontfamily.md) class topic.

## -remarks
Set the FontFamily property to specify the default font family to use for all text in the [RichTextBlock](richtextblock.md). You can override this value for specific text elements in the [RichTextBlock](richtextblock.md) by setting the [TextElement.FontFamily](../microsoft.ui.xaml.documents/textelement_fontfamily.md) property.

## -examples

## -see-also
[TextElement.FontFamily](../microsoft.ui.xaml.documents/textelement_fontfamily.md)
