---
-api-id: P:Microsoft.UI.Xaml.Controls.TextBlock.TextDecorations
-api-type: winrt property
---

<!-- Property syntax.
public TextDecorations TextDecorations { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TextBlock.TextDecorations

## -description

Gets or sets a value that indicates what decorations are applied to the text.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<TextBlock TextDecorations="textDecorationsMemberName"/>
```

## -xaml-values

<dl><dt>textDecorationsMemberName</dt><dd>textDecorationsMemberNameA named constant of the TextDecorations enumeration.</dd>
</dl>

## -property-value

A value of the enumeration. The default is **None**.

## -remarks

Starting with the Windows 10 Creators Update (SDK version 15063), this property is the preferred way to strikethrough or underline text.

For earlier versions of Windows, you can underline text with the [Underline](../microsoft.ui.xaml.documents/underline.md) class.

## -see-also

## -examples

This example shows how to apply decorations to text.

```xaml
<!-- Apply underline. -->
<TextBlock Text="Sample text" TextDecorations="Underline"/>

<!-- Apply underline and strikethrough. -->
<TextBlock Text="Sample text" TextDecorations="Underline, Strikethrough"/>

<!-- Apply decorations in code. -->
<TextBlock x:Name="TextBlock3" Text="Sample Text"
           Loaded="TextBlock_Loaded" />
```

```csharp
private void TextBlock_Loaded(object sender, RoutedEventArgs e)
{
    // Apply both strikethough and underline to TextBlock3.
    TextBlock3.TextDecorations =
        TextDecorations.Strikethrough | TextDecorations.Underline;
}
```
