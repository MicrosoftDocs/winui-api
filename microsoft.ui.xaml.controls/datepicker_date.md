---
-api-id: P:Microsoft.UI.Xaml.Controls.DatePicker.Date
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime Date { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.DatePicker.Date

## -description
Gets or sets the date currently set in the date picker.

## -property-value
The date currently set in the picker.

## -remarks

The date picker control has both `Date` and [SelectedDate](/uwp/api/windows.ui.xaml.controls.datepicker.selecteddate) properties. The difference between these is that `Date` is not nullable, while `SelectedDate` is nullable.

The value of `SelectedDate` is used to populate the date picker and is `null` by default. If `SelectedDate` is `null`, the `Date` property is set to 12/31/1600; otherwise, the `Date` value is synchronized with the `SelectedDate` value. When `SelectedDate` is `null`, the picker is 'unset' and shows the field names instead of a date.

To use the `Date` value in your app, you typically use a data binding to the [Date](/uwp/api/windows.ui.xaml.controls.datepicker.date) property, or handle the [DateChanged](/uwp/api/windows.ui.xaml.controls.datepicker.datechanged) event.

The `Date` property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](../windows.foundation/datetime.md) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.

+ [DateTime](/uwp/api/windows.foundation.datetime): Instantiate a [Windows.Globalization.Calendar](/uwp/api/windows.globalization.calendar) object (it is initialized to the current date). Set properties such as [Day](/uwp/api/windows.globalization.calendar.day) or [Year](/uwp/api/windows.globalization.calendar.year), or call methods such as [AddMonths](/uwp/api/windows.globalization.calendar.addmonths(system.int32)), to adjust the date. Then, call [Calendar.GetDateTime](/uwp/api/windows.globalization.calendar.getdatetime) and use the returned [DateTime](/uwp/api/windows.foundation.datetime) to set Date.
+ [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true): Call the  constructor. For the inner [System.DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), use the  constructor signature. Or, construct a default [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) (it is initialized to the current date) and call methods such as [AddMonths](/dotnet/api/system.datetimeoffset.addmonths?view=dotnet-uwp-10.0&preserve-view=true).

Another possible technique is to define a date that's available as a data object or in the data context, then set `Date` as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) that can access the date as data.

## -examples

This example demonstrates setting the `Date` property in code.

```xaml
<DatePicker x:Name="myDatePicker"/>
```

```csharp
public MainPage()
{
    this.InitializeComponent();
    myDatePicker.Date = new DateTimeOffset(new DateTime(1950, 1, 1));
}
```

## -see-also

[DateChanged](datepicker_datechanged.md), [Date picker](/windows/apps/design/controls/date-picker)
