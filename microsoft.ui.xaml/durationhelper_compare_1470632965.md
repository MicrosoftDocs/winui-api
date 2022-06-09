---
-api-id: M:Microsoft.UI.Xaml.DurationHelper.Compare(Microsoft.UI.Xaml.Duration,Microsoft.UI.Xaml.Duration)
-api-type: winrt method
---

<!-- Method syntax
public int Compare(Windows.UI.Xaml.Duration duration1, Windows.UI.Xaml.Duration duration2)
-->

# Microsoft.UI.Xaml.DurationHelper.Compare

## -description

Compares value equality of two [Duration](duration.md) structures. C**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

# and Microsoft Visual Basic code should use [Duration.Compare](/dotnet/api/windows.ui.xaml.duration.compare?view=dotnet-uwp-10.0&preserve-view=true) instead.

## -parameters

### -param duration1

The first [Duration](duration.md) to compare.

### -param duration2

The second [Duration](duration.md) to compare.

## -returns

If *duration1* is less than *duration2*, a negative value that represents the difference. If *duration1* is equal to *duration2*, zero. If *duration1* is greater than *duration2*, a positive value that represents the difference.

## -remarks

[Duration](duration.md)instances with a value of **Automatic**are a special case with the following return values:

+ If *duration1* is **Automatic** and *duration2* is not, -1 is returned.
+ If *duration1* is **Automatic** and *duration2* is also **Automatic**, 0 is returned.
+ If *duration1* is not **Automatic** and *duration2* is **Automatic**, 1 is returned.

## -examples

## -see-also
