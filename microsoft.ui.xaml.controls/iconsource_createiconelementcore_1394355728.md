---
-api-id: M:Microsoft.UI.Xaml.Controls.IconSource.CreateIconElementCore
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.IconSource.CreateIconElementCore

<!--
protected virtual Microsoft.UI.Xaml.Controls.IconElement CreateIconElementCore ();
-->

## -description

Creates an icon UI element.

## -returns

An instance of the [IconElement](iconelement.md) subtype that the source is associated with. For example, `FontIconSource.CreateIconElementCore()` returns an instance of [FontIcon](fonticon.md) with all of the [FontIcon](fonticon.md) properties set to the corresponding properties on the source. This object is then kept track of by the base class so it can update the properties on that object when the properties on the source change.

## -remarks

Called when the public [CreateIconElement](iconsource_createiconelement_436878877.md) method is called.

## -see-also

## -examples
