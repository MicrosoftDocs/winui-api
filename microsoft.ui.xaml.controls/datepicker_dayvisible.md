---
-api-id: P:Microsoft.UI.Xaml.Controls.DatePicker.DayVisible
-api-type: winrt property
---

<!-- Property syntax
public bool DayVisible { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.DatePicker.DayVisible

## -description
Gets or sets a value that indicates whether the day selector is shown.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<DatePicker DayVisible="bool"/>
```


## -property-value
**true** if the day selector is shown; otherwise, **false**. The default is **true**.

## -remarks

By default, the [DatePicker](datepicker.md) shows [ComboBox](combobox.md) elements to select the month, day, and year. Set `DayVisible` to **false** to hide the [ComboBox](combobox.md) that displays or changes the day component of a date.

Here's the picker with the day field hidden.

![A date picker with the day field hidden.](images/date-time/date-picker-day-hidden.png)

## -examples

## -see-also

[MonthVisible](datepicker_monthvisible.md), [YearVisible](datepicker_yearvisible.md), [DayFormat](datepicker_dayformat.md) [Date picker](/windows/apps/design/controls/date-picker)
