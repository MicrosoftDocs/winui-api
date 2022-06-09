---
-api-id: P:Microsoft.UI.Xaml.Controls.TextBox.HorizontalTextAlignment
-api-type: winrt property
---

<!-- Property syntax.
public TextAlignment HorizontalTextAlignment { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TextBox.HorizontalTextAlignment

## -description

Gets or sets a value that indicates how text is aligned in the TextBox.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<TextBox HorizontalTextAlignment="textAlignmentValue"/>
```

## -xaml-values

<dl><dt>textAlignmentValue</dt><dd>textAlignmentValueA named constant of the TextAlignment enumeration, such as Left.</dd>
</dl>

## -property-value

One of the [TextAlignment](../microsoft.ui.xaml/textalignment.md) enumeration values that specifies how text is aligned. The default is **Left**.

## -remarks

This property provides the same functionality as the **TextAlignment** property. If both properties are set to conflicting values, the last one set is used.

Apps that target the Fall Creators Update (SDK 16299) or later should use this property instead of **TextAlignment**. If your app also supports previous versions, see [Version adaptive apps: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-apps) for more info.

## -see-also

## -examples

