---
-api-id: T:Microsoft.UI.Xaml.Media.TranslateTransform
-api-type: winrt class
---

<!-- Class syntax.
public class TranslateTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.ITranslateTransform
-->

# Microsoft.UI.Xaml.Media.TranslateTransform

## -description
Translates (moves) an object in the two-dimensional x-y coordinate system.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<TranslateTransform .../>
```


## -remarks

## -examples
This example uses a TranslateTransform to offset text. In this example, a slightly offset copy of text below the primary text creates a shadow effect.



[!code-xaml[TranslateTransform_1](../microsoft.ui.xaml/code/transforms/csharp/Translate_Transform_1.xaml#SnippetTranslateTransform_1)]



[!code-xaml[TranslateTransform_2](../microsoft.ui.xaml/code/transforms/csharp/Translate_Transform_2.xaml#SnippetTranslateTransform_2)]

[!code-csharp[TranslateTransform_2_code](../microsoft.ui.xaml/code/transforms/csharp/Translate_Transform_2.xaml.cs#SnippetTranslateTransform_2_code)]

## -see-also
[XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample), [Transform](transform.md)
