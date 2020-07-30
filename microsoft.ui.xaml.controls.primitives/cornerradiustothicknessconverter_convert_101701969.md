---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusToThicknessConverter.Convert(System.Object,Windows.UI.Xaml.Interop.TypeName,System.Object,System.String)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusToThicknessConverter.Convert(System.Object,Windows.UI.Xaml.Interop.TypeName,System.Object,System.String)

<!--
public object Convert (object value, System.Type targetType, object parameter, string language);
-->

## -description

Converts a CornerRadius value to a [Thickness](/uwp/api/windows.ui.xaml.thickness) value, while also extracting the fields specified by [ConversionKind](cornerradiustothicknessconverter_conversionkind.md) (leaving others set to 0).

## -parameters

### -param value

The source CornerRadius being passed to the target.

### -param targetType

The type of the target property. Part of the [IValueConverter.Convert](/uwp/api/windows.ui.xaml.data.ivalueconverter.convert) interface method, but not used.

### -param parameter

An optional parameter to be used in the converter logic. Part of the [IValueConverter.Convert](/uwp/api/windows.ui.xaml.data.ivalueconverter.convert) interface method, but not used.

### -param language

The language of the conversion. Part of the [IValueConverter.Convert](/uwp/api/windows.ui.xaml.data.ivalueconverter.convert) interface method, but not used.

## -returns

The converted [Thickness](/uwp/api/windows.ui.xaml.thickness) value to be passed to the target dependency property.

## -remarks

## -see-also

## -examples
