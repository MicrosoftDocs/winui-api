---
-api-id: P:Microsoft.UI.Xaml.FrameworkElement.FocusVisualMargin
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness FocusVisualMargin { get;  set; }
-->

# Microsoft.UI.Xaml.FrameworkElement.FocusVisualMargin

## -description

Gets or sets the outer margin of the focus visual for a [FrameworkElement](frameworkelement.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

Provides margin values for the focus visual. The default is a [Thickness](thickness.md) with all properties (dimensions) equal to 0. A different runtime default is often provided by individual control templates.

## -remarks

A negative margin will push the border away from the center of the control, and a positive margin will move the border closer to the center of the control.

Non-integral values for margin values are technically permitted, but should typically be avoided.

[HighVisibility](focusvisualkind.md) and [Reveal](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border.

For more info, see [High Visibility Focus Visuals](/windows/apps/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals) and [Reveal focus](/windows/apps/design/style/reveal-focus).

## -examples

```xaml
<Button Content="Button"
        FocusVisualMargin="-3"/>
```

## -see-also

[High Visibility Focus Visuals](/windows/apps/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals), [Reveal focus](/windows/apps/design/style/reveal-focus), [FocusVisualPrimaryBrush](frameworkelement_focusvisualprimarybrush.md), [FocusVisualSecondaryBrush](frameworkelement_focusvisualsecondarybrush.md), [FocusVisualPrimaryThickness](frameworkelement_focusvisualprimarythickness.md), [FocusVisualSecondaryThickness](frameworkelement_focusvisualsecondarythickness.md)
