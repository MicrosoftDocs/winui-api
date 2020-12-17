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
The Date property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](/uwp/api/windows.foundation.datetime) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.
+ [DateTime](/uwp/api/windows.foundation.datetime): Instantiate a [Windows.Globalization.Calendar](/uwp/api/windows.globalization.calendar) object (it is initialized to the current date). Set properties such as [Day](/uwp/api/windows.globalization.calendar.day) or [Year](/uwp/api/windows.globalization.calendar.year), or call methods such as [AddMonths](/uwp/api/windows.globalization.calendar.addmonths(system.int32)), to adjust the date. Then, call [Calendar.GetDateTime](/uwp/api/windows.globalization.calendar.getdatetime) and use the returned [DateTime](/uwp/api/windows.foundation.datetime) to set Date.
+ [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true): Call the  constructor. For the inner [System.DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), use the  constructor signature. Or, construct a default [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) (it is initialized to the current date) and call methods such as [AddMonths](/dotnet/api/system.datetimeoffset.addmonths?view=dotnet-uwp-10.0&preserve-view=true).


Another possible technique is to define a date that's available as a data object or in the data context, then set Date as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) that can access the date as data.

## -examples

## -see-also
[DateChanged](datepicker_datechanged.md), [Quickstart: Adding a DatePicker](/previous-versions/windows/apps/dn308514(v=win.10)), [XAML DatePicker and TimePicker controls sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20DatePicker%20and%20TimePicker%20controls%20sample)
