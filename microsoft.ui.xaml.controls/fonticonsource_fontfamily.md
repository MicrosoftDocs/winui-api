---
-api-id: P:Microsoft.UI.Xaml.Controls.FontIconSource.FontFamily
-api-type: winrt property
---
<!-- Property syntax.
public FontFamily FontFamily { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.FontIconSource.FontFamily


## -description

Gets or sets the font used to display the icon glyph.


**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The font used to display the icon glyph. The default is the font family defined by the `SymbolThemeFontFamily` theme resource (see Remarks).


## -remarks

If you don't specify a `FontFamily`, or you specify a `FontFamily` that is not available on the system at runtime, the `FontIcon` falls back to the default font family defined by the `SymbolThemeFontFamily` theme resource.

By default, Windows uses the [**Segoe Fluent Icon**](/windows/apps/design/style/segoe-ui-symbol-font) font family. If your app is run on Windows 10, version 20H2 or earlier, the Segoe Fluent Icon font family is not available and the `SymbolThemeFontFamily` resource falls back to the [**Segoe MDL2 Asset**](/windows/apps/design/style/segoe-ui-symbol-font) font family instead. 

To use glyphs from the default system font, don't set the `FontFamily` property, let it use its default value instead.

## -see-also


## -examples

```xaml
<FontIcon FontFamily="Segoe UI Emoji" Glyph="&#x25B6;"/>
```


## -xaml-syntax

```xaml
<FontIconSource FontFamily="fontFamilyValue"/>
```


## -xaml-values

<dl><dt>fontFamilyValue</dt><dd>fontFamilyValueA string representation of a FontFamily value, possibly including fallback values or indexes within a font file, or a URI where the font family is packaged. For more information on the syntax, see FontFamily.</dd>
</dl>


