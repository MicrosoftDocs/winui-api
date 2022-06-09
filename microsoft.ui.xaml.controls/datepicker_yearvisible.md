---
-api-id: P:Microsoft.UI.Xaml.Controls.DatePicker.YearVisible
-api-type: winrt property
---

<!-- Property syntax
public bool YearVisible { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.DatePicker.YearVisible

## -description

Gets or sets a value that indicates whether the year selector is shown.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<DatePicker YearVisible="bool"/>
```

## -property-value

**true** if the year selector is shown; otherwise, **false**. The default is **true**.

## -remarks

By default, the [DatePicker](datepicker.md) shows [ComboBox](combobox.md) elements to select the month, day, and year. Set `YearVisible` to **false** to hide the [ComboBox](combobox.md) that displays or changes the year component of a date.

Here's the picker with the year field hidden.

![A date picker with the year field hidden.](images/date-time/date-picker-year-hidden.png)

## -examples

## -see-also

[DayVisible](datepicker_dayvisible.md), [MonthVisible](datepicker_monthvisible.md), [YearFormat](datepicker_yearformat.md), [Date picker](/windows/apps/design/controls/date-picker)
