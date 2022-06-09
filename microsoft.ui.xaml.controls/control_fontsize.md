---
-api-id: P:Microsoft.UI.Xaml.Controls.Control.FontSize
-api-type: winrt property
---

<!-- Property syntax
public double FontSize { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Control.FontSize

## -description

Gets or sets the size of the text in this control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<control FontSize="double"/>
```

## -property-value

The size of the text in the [Control](control.md), in pixels. The default is 11.

## -remarks

The unit measure for FontSize is pixels, measuring the line height of the characters in the font. The apparent size of text in the UI can vary based on the current scaling. If you want to use different FontSize values for different scalings, you can do this using the [Resource Management System](/windows/uwp/app-resources/).

## -examples

## -see-also

[Text controls](/windows/apps/design/controls/text-controls), [Text scaling](/windows/apps/design/input/text-scaling), [Adjust layout and fonts, and support RTL](/windows/apps/design/globalizing/adjust-layout-and-fonts--and-support-rtl)
