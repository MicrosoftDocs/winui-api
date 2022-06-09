---
-api-id: M:Microsoft.UI.Xaml.GridLengthHelper.FromValueAndType(System.Double,Microsoft.UI.Xaml.GridUnitType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.GridLength FromValueAndType(System.Double value, Windows.UI.Xaml.GridUnitType type)
-->

# Microsoft.UI.Xaml.GridLengthHelper.FromValueAndType

## -description
Creates a new [GridLength](gridlength.md) value based on a possible number of pixels, and a [GridUnitType](gridunittype.md). C**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

# and Microsoft Visual Basic code should use the [ GridLength(Double,GridUnitType)](/dotnet/api/windows.ui.xaml.gridlength.-ctor?view=dotnet-uwp-10.0&preserve-view=true#Windows_UI_Xaml_GridLength__ctor_System_Double_Windows_UI_Xaml_GridUnitType_) constructor instead.

## -parameters
### -param value
A numeric value. This might be a pixel height or width to specify, if *type* is specified as **Pixel**, or a factor, if *type* is specified as **Star**. This value is ignored if *type* is specified as **Auto**.

### -param type
A value of the enumeration that specifies which unit type the [GridLength](gridlength.md) represents.

## -returns
The created [GridLength](gridlength.md).

## -remarks

## -examples

## -see-also
