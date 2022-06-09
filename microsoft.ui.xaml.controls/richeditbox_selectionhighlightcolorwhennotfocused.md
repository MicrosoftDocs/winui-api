---
-api-id: P:Microsoft.UI.Xaml.Controls.RichEditBox.SelectionHighlightColorWhenNotFocused
-api-type: winrt property
---

<!-- Property syntax.
public SolidColorBrush SelectionHighlightColorWhenNotFocused { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichEditBox.SelectionHighlightColorWhenNotFocused

## -description
Gets or sets the brush used to highlight the selected text when the RichEditBox does not have focus.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<RichEditBox SelectionHighlightColorWhenNotFocused="{StaticResource resourceName}"/>
- or -
<RichEditBox SelectionHighlightColorWhenNotFocused="colorString"/>

```

## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>

## -property-value
The brush used to highlight the selected text when [RichEditBox](richeditbox.md) loses focus. The default is a null brush from a pure code perspective, but the default control template for [RichEditBox](richeditbox.md) applies a Transparent brush for this in a runtime instance of a [RichEditBox](richeditbox.md) control. To disable the SelectionHighlightColorWhenNotFocused, set the brush to Transparent once again.

## -remarks

## -see-also
[SelectionHighlightColor](richeditbox_selectionhighlightcolor.md)

## -examples

