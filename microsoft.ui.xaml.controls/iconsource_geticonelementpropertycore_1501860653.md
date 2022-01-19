---
-api-id: M:Microsoft.UI.Xaml.Controls.IconSource.GetIconElementPropertyCore(Microsoft.UI.Xaml.DependencyProperty)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.IconSource.GetIconElementPropertyCore(Microsoft.UI.Xaml.DependencyProperty)

<!--
protected virtual Microsoft.UI.Xaml.DependencyProperty GetIconElementPropertyCore (Microsoft.UI.Xaml.DependencyProperty iconSourceProperty);
-->

## -description

Maps [IconSource](iconsource.md) properties to IconElementProperties.

## -parameters

### -param iconSourceProperty

The [IconSource](iconsource.md) used as the icon content.

## -returns

An object that provides support for value expressions, data binding, animation, and property change notification. For more info on how DependencyProperty values serve as identifiers for dependency properties, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

## -remarks

When a property on an IconSource is updated, the base class updates the properties on all of the created IconElements it is tracking.  This method is how the base class is able to take a dependency property associated with the icon source subtype and set the property on the corresponding IconElement subtype. For example, `FontIconSource.GetIconElementPropertyCore(FontIconSource.FontSizeProperty)` returns a [FontIconSource.FontSizeProperty](fonticonsource_fontsizeproperty.md)

## -see-also

## -examples
