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

## -property-value
The minimum Gregorian year available for picking.

## -remarks
The MinYear property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](/uwp/api/windows.foundation.datetime) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.
+ [DateTime](/uwp/api/windows.foundation.datetime): Instantiate a [Windows.Globalization.Calendar](/uwp/api/windows.globalization.calendar) object (it is initialized to the current date). Set [Year](/uwp/api/windows.globalization.calendar.year), or call [AddYears](/uwp/api/windows.globalization.calendar.addyears(system.int32)), to adjust the date. Then, call [Calendar.GetDateTime](/uwp/api/windows.globalization.calendar.getdatetime) and use the returned [DateTime](/uwp/api/windows.foundation.datetime) to set MinYear.
+ [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true): Call the  constructor. For the inner [System.DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), use the  constructor signature. Or, construct a default [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) (it is initialized to the current date) and call [AddYears](/dotnet/api/system.datetimeoffset.addyears?view=dotnet-uwp-10.0&preserve-view=true).


Another possible technique is to define a date that's available as a data object or in the data context, then set MinYear as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) that can access the date as data.

## -examples

## -see-also
[MaxYear](datepicker_maxyear.md), [Quickstart: Adding a DatePicker](/previous-versions/windows/apps/dn308514(v=win.10))
