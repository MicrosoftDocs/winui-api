---
-api-id: M:Microsoft.UI.Xaml.PropertyMetadata.Create(Microsoft.UI.Xaml.CreateDefaultValueCallback,Microsoft.UI.Xaml.PropertyChangedCallback)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.PropertyMetadata Create(Windows.UI.Xaml.CreateDefaultValueCallback createDefaultValueCallback, Windows.UI.Xaml.PropertyChangedCallback propertyChangedCallback)
-->

# Microsoft.UI.Xaml.PropertyMetadata.Create

## -description
Creates a [PropertyMetadata](propertymetadata.md) value, specifying a callback that establishes a default value for a dependency property, and a property-changed callback.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param createDefaultValueCallback
A reference to the callback method that provides a default property value.

### -param propertyChangedCallback
A reference to the callback method that is invoked by the property system when a dependency property value changes.

## -returns
The newly created dependency property metadata.

## -remarks

## -examples

## -see-also
[Create(Object)](propertymetadata_create_1554665429.md), [Create(Object, PropertyChangedCallback)](propertymetadata_create_1342341299.md), [Create(CreateDefaultValueCallback)](propertymetadata_create_1683336252.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
