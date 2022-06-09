---
-api-id: P:Microsoft.UI.Xaml.Controls.TimePicker.MinuteIncrement
-api-type: winrt property
---

<!-- Property syntax
public int MinuteIncrement { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TimePicker.MinuteIncrement

## -description
Gets or sets a value that indicates the time increments shown in the minute picker. For example, 15 specifies that the [TimePicker](timepicker.md) minute control displays only the choices 00, 15, 30, 45.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<TimePicker MinuteIncrement="int"/>
```

## -property-value

An integer from 0-59 that indicates the increments shown in the minute picker. The default is 1.

## -remarks

You can set the `MinuteIncrement` property to indicate the time increments shown in the minute picker. For example, 15 specifies that the `TimePicker` minute control displays only the choices 00, 15, 30, 45.

## -examples

This example shows a time picker using 15-minute increments.

```xaml
<TimePicker MinuteIncrement="15"/>
```

![A time picker showing 15 minute increments.](images/date-time/time-picker-minute-increment.png)

## -see-also
