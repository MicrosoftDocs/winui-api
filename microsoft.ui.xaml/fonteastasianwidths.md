---
-api-id: T:Microsoft.UI.Xaml.FontEastAsianWidths
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FontEastAsianWidths : int
-->

# FontEastAsianWidths

## -description
Provides a mechanism for selecting glyphs of different width styles.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
 
```


## -enum-fields
### -field Normal:0
Default width style.

### -field Full:1
Replaces uniform width glyphs with full width (usually em) glyphs.

### -field Half:2
Replaces uniform width glyphs with half width (half em) glyphs

### -field Proportional:3
Replaces uniform width glyphs with proportionally spaced glyphs.

### -field Quarter:4
Replaces uniform width glyphs with one-quarter width (one-quarter em) glyphs.

### -field Third:5
Replaces uniform width glyphs with one-third width (one-third em) glyphs.


## -remarks
This enumeration is used by the [Typography.EastAsianWidths](/windows/winui/api/microsoft.ui.xaml.documents.typography#xaml-attached-properties) attached property.

## -examples

## -see-also
[Typography](../microsoft.ui.xaml.documents/typography.md)
