---
-api-id: P:Microsoft.UI.Xaml.PropertyMetadata.CreateDefaultValueCallback
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.CreateDefaultValueCallback CreateDefaultValueCallback { get; }
-->

# Microsoft.UI.Xaml.PropertyMetadata.CreateDefaultValueCallback

## -description
Gets a reference to the callback method that provides a default property value.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
A reference to the callback method that provides a default property value.

## -remarks
Use a [CreateDefaultValueCallback](createdefaultvaluecallback.md) instead of a fixed constant default value in any case where the default value of a dependency property might be thread-bound. The [CreateDefaultValueCallback](createdefaultvaluecallback.md) becomes a factory for default values whenever there is a need to get default values of properties on threads other than the main UI thread.

In order to establish a [CreateDefaultValueCallback](createdefaultvaluecallback.md) pattern for a dependency property, use one of the static [Create](propertymetadata_create_1554665429.md) methods instead of using the [PropertyMetadata](propertymetadata_propertymetadata_425806119.md) constructor when you define the metadata for the property. That metadata is submitted to the [Register](dependencyproperty_register_928563513.md) call. For more info, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties). As with a property-changed callback, the [CreateDefaultValueCallback](createdefaultvaluecallback.md) method should be a static method of the type that registers the dependency property. The method does not have to be public.

## -examples

## -see-also
[DependencyProperty.Register](dependencyproperty_register_928563513.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties)
