---
-api-id: P:Microsoft.UI.Xaml.Controls.CalendarDatePicker.DisplayMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.CalendarViewDisplayMode DisplayMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.CalendarDatePicker.DisplayMode

## -description
Gets or sets a value that indicates whether the calendar shows selections for month, year, or decade in the picker's [CalendarView](calendarview.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<CalendarDatePicker DisplayMode="calendarViewDisplayModeMemberName" />
```


## -xaml-values
<dl><dt>calendarViewDisplayModeMemberName</dt><dd>calendarViewDisplayModeMemberNameA CalendarViewDisplayMode named constant, such as Month or Year.</dd>
</dl>
## -property-value
A value of the enumeration that indicates whether the calendar shows selections for month, year, or decade. The default is **Month**.

## -remarks
This property affects the [CalendarDatePicker](calendardatepicker.md)'s internal [CalendarView](calendarview.md). For more info, see [CalendarView.DisplayMode](calendarview_displaymode.md).

## -examples

## -see-also
[CalendarView.DisplayMode](calendarview_displaymode.md)
