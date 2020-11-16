---
-api-id: M:Microsoft.UI.Xaml.Controls.StyleSelector.SelectStyle(System.Object,Microsoft.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Style SelectStyle(System.Object item, Windows.UI.Xaml.DependencyObject container)
-->

# Microsoft.UI.Xaml.Controls.StyleSelector.SelectStyle

## -description
Returns a specific [Style](../microsoft.ui.xaml/style.md) based on custom logic.

## -parameters
### -param item
The content.

### -param container
The element to which the style is applied.

## -returns
An application-specific style to apply; may also return null.

## -remarks
To provide a specific style in a derived class, override the [SelectStyleCore](styleselector_selectstylecore_2089986252.md) method.

## -examples

## -see-also
