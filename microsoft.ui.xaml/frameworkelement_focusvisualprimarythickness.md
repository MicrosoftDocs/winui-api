---
-api-id: P:Microsoft.UI.Xaml.FrameworkElement.FocusVisualPrimaryThickness
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness FocusVisualPrimaryThickness { get;  set; }
-->

# Microsoft.UI.Xaml.FrameworkElement.FocusVisualPrimaryThickness

## -description

Gets or sets the thickness of the outer border of a `HighVisibility` or `Reveal` focus visual for a [FrameworkElement](frameworkelement.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The thickness of the outer border of a [HighVisibility](focusvisualkind.md) focus visual. The default is 2.

## -remarks

[HighVisibility](focusvisualkind.md) and [Reveal](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border.

For more info, see [High Visibility Focus Visuals](/windows/apps/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals) and [Reveal focus](/windows/apps/design/style/reveal-focus).

## -examples

```xaml
<Button Content="Button"
        FocusVisualPrimaryThickness="2"/>
```

## -see-also

[High Visibility Focus Visuals](/windows/apps/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals), [Reveal focus](/windows/apps/design/style/reveal-focus), [FocusVisualPrimaryBrush](frameworkelement_focusvisualprimarybrush.md), [FocusVisualSecondaryBrush](frameworkelement_focusvisualsecondarybrush.md), [FocusVisualSecondaryThickness](frameworkelement_focusvisualsecondarythickness.md)
