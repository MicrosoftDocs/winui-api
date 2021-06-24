---
-api-id: P:Microsoft.UI.Xaml.Media.ThemeShadow.Receivers
-api-type: winrt property
---

<!-- Property syntax.
public UIElementWeakCollection Receivers { get; }
-->

# Microsoft.UI.Xaml.Media.ThemeShadow.Receivers

## -description

Gets a collection of UI elements that this ThemeShadow is cast on.

## -property-value

A collection of UI elements that this ThemeShadow is cast on.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/apps/design/layout/depth-shadow).

To cast a shadow effect from a XAML UI element that isn't in a [Popup](../microsoft.ui.xaml.controls.primitives/popup.md), you must explicitly specify the other UI elements that can receive the shadow by adding them to this Receivers collection.

Receivers cannot be an ancestor of the caster in the visual tree.

## -see-also

[Z-depth and shadow](/windows/apps/design/layout/depth-shadow), [ThemeShadow](themeshadow.md), [UIElement.Shadow](../microsoft.ui.xaml/uielement_shadow.md)

## -examples

