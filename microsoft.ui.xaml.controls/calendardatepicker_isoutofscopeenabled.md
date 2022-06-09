---
-api-id: P:Microsoft.UI.Xaml.Controls.CalendarDatePicker.IsOutOfScopeEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsOutOfScopeEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.CalendarDatePicker.IsOutOfScopeEnabled

## -description
Gets or sets a value that indicates whether out-of-scope calendar items are shown with a unique foreground color in the picker's [CalendarView](calendarview.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<CalendarDatePicker IsOutOfScopeEnabled="bool" .../>
```


## -property-value
**true** if out-of-scope calendar items are shown with a unique color; **false** if they are shown with the same color as in-scope items. The default is **true**.

## -remarks
This property affects the [CalendarDatePicker](calendardatepicker.md)'s internal [CalendarView](calendarview.md). For more info, see [CalendarView.IsOutOfScopeEnabled](calendarview_isoutofscopeenabled.md).

## -examples

## -see-also
[CalendarView.IsOutOfScopeEnabled](calendarview_isoutofscopeenabled.md)
