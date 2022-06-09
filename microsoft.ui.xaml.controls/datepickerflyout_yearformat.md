---
-api-id: P:Microsoft.UI.Xaml.Controls.DatePickerFlyout.YearFormat
-api-type: winrt property
---

<!-- Property syntax
public string YearFormat { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.DatePickerFlyout.YearFormat

## -description
Gets or sets the display format for the year value.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<DatePickerFlyout YearFormat="formatString"/>
```


## -xaml-values
<dl><dt>formatString</dt><dd>formatStringThe string format to use to display the year. See Remarks.</dd>
</dl>
## -property-value
The display format for the year value.

## -remarks
Change the format of the year value by setting the YearFormat property.

The string content of the year value is created by a [DateTimeFormatter](/uwp/api/windows.globalization.datetimeformatting.datetimeformatter). You inform the [DateTimeFormatter](/uwp/api/windows.globalization.datetimeformatting.datetimeformatter) how to format the year value by providing a string that is either a *format template* or a *format pattern*. Common templates and patterns for year values are listed in the following table.

<table>
   <tr><th>format pattern</th><th>format template</th></tr>
   <tr><td>`{year.full} | {year.abbreviated} | {year.abbreviated(n)}`</td><td>`year | year.full | year.abbreviated`</td></tr>
   <tr><td>`{era.full} | {era.abbreviated} | {era.abbreviated(n)}`</td><td>n/a</td></tr>
</table>

> [!NOTE]
> "Era" only applies when the [CalendarIdentifier](datepicker_calendaridentifier.md) is set to the Japanese calendar. For the Japanese calendar, era is shown in the year picker.

For the complete list of format templates and format patterns, see the Remarks section of the [DateTimeFormatter](/uwp/api/windows.globalization.datetimeformatting.datetimeformatter) class documentation.

> [!NOTE]
> Some date formats should be avoided if the date picker might be displayed in a small area, such as adding the full string value of the day of week. These strings can be long and might be clipped if the DatePicker's width is forced to be small.

## -examples

## -see-also
[DayFormat](datepickerflyout_dayformat.md), [MonthFormat](datepickerflyout_monthformat.md), [DatePicker](datepicker.md), [DatePicker.DayFormat](datepicker_dayformat.md), [DatePicker.MonthFormat](datepicker_monthformat.md), [DatePicker.YearFormat](datepicker_yearformat.md), [DateTimeFormatter](/uwp/api/windows.globalization.datetimeformatting.datetimeformatter), [How to use patterns to format dates and times](/previous-versions/windows/apps/jj673581(v=win.10))
