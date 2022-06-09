---
-api-id: P:Microsoft.UI.Xaml.Controls.CalendarDatePicker.FirstDayOfWeek
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.DayOfWeek FirstDayOfWeek { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.CalendarDatePicker.FirstDayOfWeek

## -description
Gets or sets a value that indicates which day is shown as the first day of the week in the picker's [CalendarView](calendarview.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<CalendarDatePicker FirstDayOfWeek="dayOfWeekMemberName"/>
```


## -xaml-values
<dl><dt>dayOfWeekMemberName</dt><dd>dayOfWeekMemberNameA DayOfWeek named constant, such as Sunday or Monday.</dd>
</dl>
## -property-value
A value of the enumeration that indicates which day is shown as the first day of the week.

## -remarks
This property affects the [CalendarDatePicker](calendardatepicker.md)'s internal [CalendarView](calendarview.md). For more info, see [CalendarView.FirstDayOfWeek](calendarview_firstdayofweek.md).

## -examples

## -see-also
[CalendarView.FirstDayOfWeek](calendarview_firstdayofweek.md)
