---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter.Convert(System.Object,Windows.UI.Xaml.Interop.TypeName,System.Object,System.String)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter.Convert(System.Object,Windows.UI.Xaml.Interop.TypeName,System.Object,System.String)

<!--
public object Convert (object value, System.Type targetType, object parameter, string language);
-->

## -description

Converts the source CornerRadius by extracting only the fields specified by the [Filter](cornerradiusfilterconverter_filter.md) and leaving others set to 0.

## -parameters

### -param value

The source CornerRadius being passed to the target.

### -param targetType

The type of the target property. Part of the [IValueConverter](/uwp/api/windows.ui.xaml.data.ivalueconverter) interface, but not used.

### -param parameter

An optional parameter to be used in the converter logic. Part of the [IValueConverter](/uwp/api/windows.ui.xaml.data.ivalueconverter) interface, but not used.

### -param language

The language of the conversion. Part of the [IValueConverter](/uwp/api/windows.ui.xaml.data.ivalueconverter) interface, but not used.

## -returns

The converted CornerRadius/double value to be passed to the target dependency property.

## -remarks

## -see-also

[IValueConverter.Convert](/uwp/api/windows.ui.xaml.data.ivalueconverter.convert)

## -examples
