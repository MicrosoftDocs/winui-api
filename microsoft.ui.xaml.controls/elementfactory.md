---
-api-id: T:Microsoft.UI.Xaml.Controls.ElementFactory
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ElementFactory

<!--
public class ElementFactory : Windows.UI.Xaml.DependencyObject, Microsoft.UI.Xaml.Controls.IElementFactoryShim
-->

## -description

Represents the base class for components that create and optionally recycle elements for use in a [Layout](layout.md).

## -remarks

ElementFactory is the base class for components that create and recycle elements. To create a custom element factory, override the [GetElementCore](elementfactory_getelementcore_2147345951.md) and [RecycleElementCore](elementfactory_recycleelementcore_1833106651.md) methods in a derived class. If you need an implemented element factory, use [RecyclingElementFactory](recyclingelementfactory.md).

You can set an instance of ElementFactory as the [ItemTemplate](itemsrepeater_itemtemplate.md) property of an [ItemsRepeater](itemsrepeater.md).

## -see-also

[RecyclingElementFactory](recyclingelementfactory.md)

## -examples

