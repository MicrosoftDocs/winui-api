---
-api-id: T:Microsoft.UI.Xaml.FontVariants
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FontVariants : int
-->

# FontVariants

## -description

Describes a font variant value for the [Typography.Variants](/windows/winui/api/microsoft.ui.xaml.documents.typography**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

#xaml-attached-properties) attached property.

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
 
```

## -enum-fields

### -field Normal:0

Default font behavior. Font scaling and positioning is normal.

### -field Superscript:1

Replaces a default glyph with a superscript glyph. Superscript is commonly used for footnotes.

### -field Subscript:2

Replaces a default glyph with a subscript glyph.

### -field Ordinal:3

Replaces a default glyph with an ordinal glyph, or it might combine glyph substitution with positioning adjustments for proper placement. Ordinal forms are normally associated with numeric notation of an ordinal word, such as "1st" for "first".

### -field Inferior:4

Replaces a default glyph with an inferior glyph, or it might combine glyph substitution with positioning adjustments for proper placement. Inferior forms are typically used in chemical formulas or mathematical notation.

### -field Ruby:5

Replaces a default glyph with a smaller Japanese Kana glyph. This is used to clarify the meaning of Kanji, which might be unfamiliar to the reader.

## -remarks

This enumeration is used by the [Typography.Variants](/windows/winui/api/microsoft.ui.xaml.documents.typography#xaml-attached-properties) attached property.

Some fonts might support a subset of variant values, or ignore the setting completely.

Some fonts might also algorithmically approximate a font form instead of supporting [Typography.Variants](/windows/winui/api/microsoft.ui.xaml.documents.typography#xaml-attached-properties). 

## -examples

## -see-also

[Typography](../microsoft.ui.xaml.documents/typography.md)
