---
-api-id: T:Microsoft.UI.Xaml.FontCapitals
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FontCapitals : int
-->

# FontCapitals

## -description
Describes the capital letter style value for the [Typography.Capitals](/windows/winui/api/microsoft.ui.xaml.documents.typography**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

#xaml-attached-properties) attached property.

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
 
```


## -enum-fields
### -field Normal:0
Capital letters render normally.

### -field AllSmallCaps:1
Both capital and lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height.

### -field SmallCaps:2
Lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height.

### -field AllPetiteCaps:3
Both capital and lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height. Petite capitals are smaller than small capitals.

### -field PetiteCaps:4
Lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height. Petite capitals are smaller than small capitals.

### -field Unicase:5
Capital letters display in unicase. Unicase fonts render both uppercase and lowercase letters in a mixture of uppercase and lowercase glyphs determined by the type designer.

### -field Titling:6
Glyph forms are substituted with a typographic form specifically designed for titles.


## -remarks
This enumeration is used by the [Typography.Capitals](/windows/winui/api/microsoft.ui.xaml.documents.typography#xaml-attached-properties) attached property.

## -examples

## -see-also
[Typography](../microsoft.ui.xaml.documents/typography.md)
