---
-api-id: P:Microsoft.UI.Xaml.Controls.DatePicker.MinYear
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime MinYear { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.DatePicker.MinYear

## -description
Gets or sets the minimum Gregorian year available for picking.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
The minimum Gregorian year available for picking.

## -remarks

You can set the `MinYear` and [MaxYear](datepicker_maxyear.md) properties to restrict the date values in the picker. By default, `MinYear` is set to 100 years prior to the current date and `MaxYear` is set to 100 years past the current date.

If you set only `MinYear` or `MaxYear`, you need to ensure that a valid date range is created by the date you set and the default value of the other date; otherwise, no date will be available to select in the picker. For example, setting only `yearDatePicker.MaxYear = new DateTimeOffset(new DateTime(900, 1, 1));` creates an invalid date range with the default value of `MinYear`.

The `MinYear` property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](/uwp/api/windows.foundation.datetime) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.

+ [DateTime](/uwp/api/windows.foundation.datetime): Instantiate a [Windows.Globalization.Calendar](/uwp/api/windows.globalization.calendar) object (it is initialized to the current date). Set [Year](/uwp/api/windows.globalization.calendar.year), or call [AddYears](/uwp/api/windows.globalization.calendar.addyears(system.int32)), to adjust the date. Then, call [Calendar.GetDateTime](/uwp/api/windows.globalization.calendar.getdatetime) and use the returned [DateTime](/uwp/api/windows.foundation.datetime) to set MinYear.
+ [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true): Call the  constructor. For the inner [System.DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), use the  constructor signature. Or, construct a default [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) (it is initialized to the current date) and call [AddYears](/dotnet/api/system.datetimeoffset.addyears?view=dotnet-uwp-10.0&preserve-view=true).

Another possible technique is to define a date that's available as a data object or in the data context, then set MinYear as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) that can access the date as data.

## -examples

This example demonstrates setting the `MinYear` and `MaxYear` properties in code.

```xaml
<DatePicker x:Name="myDatePicker"/>
```

```csharp
public MainPage()
{
    this.InitializeComponent();
    myDatePicker.MinYear = new DateTimeOffset(new DateTime(1950, 1, 1));
    myDatePicker.MaxYear = DateTimeOffset.Now.AddYears(5);
}
```

## -see-also

[MaxYear](datepicker_maxyear.md), [Date picker](/windows/apps/design/controls/date-picker)
