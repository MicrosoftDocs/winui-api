---
-api-id: T:Microsoft.UI.Xaml.Controls.DatePicker
-api-type: winrt class
---

<!-- Class syntax.
public class DatePicker : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IDatePicker, Windows.UI.Xaml.Controls.IDatePicker2
-->

# Microsoft.UI.Xaml.Controls.DatePicker

## -description
Represents a control that allows a user to pick a date value.

## -xaml-syntax
```xaml
<DatePicker .../>

```

## -remarks

Use a `DatePicker` to let a user enter a date value. The user picks the date using [ComboBox](combobox.md) selection for month, day, and year values. You can customize the `DatePicker` in various ways to suit your app.

![A date picker control.](images/date-time/date-picker-closed.png)

For more info, design guidance, and code examples, see [Date picker](/windows/apps/design/controls/date-picker).

The `DatePicker` supports each of the calendar systems supported by Windows. These calendars are specified in the [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) class. The `DatePicker` uses the correct calendar for your app's default language, or you can set the [CalendarIdentifier](datepicker_calendaridentifier.md) property to use a specific calendar system.

### Formatting the date picker

By default, the date picker shows the day, month, and year. If your scenario for the date picker doesn't require all the fields, you can hide the ones you don't need. To hide a field, set its corresponding *field*Visible property to `false`. For more info, see the [DayVisible](datepicker_dayvisible.md), [MonthVisible](datepicker_monthvisible.md), and [YearVisible](datepicker_yearvisible.md) properties.

The string content of each `ComboBox` in the `DatePicker` is created by a [DateTimeFormatter](/uwp/api/windows.globalization.datetimeformatting.datetimeformatter). You can use a string that is either a *format template* or a *format pattern* to specify the format. For more info, see the [DayFormat](datepicker_dayformat.md), [MonthFormat](datepicker_monthformat.md), and [YearFormat](datepicker_yearformat.md) properties.

### Date values

The date picker control has both [Date](datepicker_date.md) / [DateChanged](datepicker_datechanged.md) and [SelectedDate](datepicker_selecteddate.md) / [SelectedDateChanged](datepicker_selecteddatechanged.md) APIs. The difference between these is that `Date` is not nullable, while `SelectedDate` is nullable.

The value of `SelectedDate` is used to populate the date picker and is `null` by default. If `SelectedDate` is `null`, the `Date` property is set to 12/31/1600; otherwise, the `Date` value is synchronized with the `SelectedDate` value. When `SelectedDate` is `null`, the picker is 'unset' and shows the field names instead of a date.

![A date picker with no date selected.](images/date-time/date-picker-no-selected-date.png)

To use the date value in your app, you typically use a data binding to the `SelectedDate` property, or handle the `SelectedDateChanged` event.

You can set the [MinYear](datepicker_minyear.md) and [MaxYear](datepicker_maxyear.md) properties to restrict the date values in the picker. By default, `MinYear` is set to 100 years prior to the current date and `MaxYear` is set to 100 years past the current date.

If you set only `MinYear` or `MaxYear`, you need to ensure that a valid date range is created by the date you set and the default value of the other date; otherwise, no date will be available to select in the picker. For example, setting only `yearDatePicker.MaxYear = new DateTimeOffset(new DateTime(900, 1, 1));` creates an invalid date range with the default value of `MinYear`.

#### Initializing a date value

The date properties can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](/uwp/api/windows.foundation.datetime) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects.

This example demonstrates setting the `SelectedDate` property in code.

```xaml
<DatePicker x:Name="myDatePicker"/>
```

```csharp
public MainPage()
{
    this.InitializeComponent();
    myDatePicker.SelectedDate = new DateTimeOffset(new DateTime(1950, 1, 1));
}
```

### DateTime and Calendar values

The date objects used in a DatePicker have a different representation depending on your programming language. C# and Visual Basic use the [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) structure that is part of .NET. Visual C++ component extensions (C++/CX) uses the [Windows::Foundation::DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime) structure. A related concept is the **Calendar** class, which influences how dates are interpreted in context. All Windows Runtime apps can use the [Windows.Globalization.Calendar](/uwp/api/windows.globalization.calendar) class. C# and Visual Basic apps can alternatively use the [System.Globalization.Calendar](/dotnet/api/system.globalization.calendar?view=dotnet-uwp-10.0&preserve-view=true) class, which has very similar functionality. (Windows Runtime app can use the base .NET [Calendar](/dotnet/api/system.globalization.calendar?view=dotnet-uwp-10.0&preserve-view=true) class but not the specific implementations for example **GregorianCalendar**.)

.NET also supports a type named [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), which is implicitly convertible to a [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). So you might see a "DateTime" type being used in .NET code that's used to set values that are really [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). For more info on the difference between [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true) and [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true), see Remarks in [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls#lightweight-styling) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the DatePicker control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>DatePickerSpacerFill</td><td>Spacer color</td></tr>
   <tr><td>DatePickerSpacerFillDisabled</td><td>Spacer color when disabled</td></tr>
   <tr><td>DatePickerHeaderForeground</td><td>Header text color</td></tr>
   <tr><td>DatePickerHeaderForegroundDisabled</td><td>Header text color when disabled</td></tr>
   <tr><td>DatePickerButtonForeground</td><td>Button text color</td></tr>
   <tr><td>DatePickerButtonForegroundPointerOver</td><td>Button text color on hover</td></tr>
   <tr><td>DatePickerButtonForegroundPressed</td><td>Button text color when pressed</td></tr>
   <tr><td>DatePickerButtonForegroundDisabled</td><td>Button text color when disabled</td></tr>
   <tr><td>DatePickerButtonForegroundFocused</td><td>Button text color when focused</td></tr>
   <tr><td>DatePickerButtonBackground</td><td>Button background color at rest</td></tr>
   <tr><td>DatePickerButtonBackgroundPointerOver</td><td>Button background color on hover</td></tr>
   <tr><td>DatePickerButtonBackgroundPressed</td><td>Button background color when pressed</td></tr>
   <tr><td>DatePickerButtonBackgroundDisabled</td><td>Button background color when disabled</td></tr>
   <tr><td>DatePickerButtonBackgroundFocused</td><td>Button background color when focused</td></tr>
   <tr><td>DatePickerButtonBorderBrush</td><td>Button border color at rest</td></tr>
   <tr><td>DatePickerButtonBorderBrushPointerOver</td><td>Button border color on hover</td></tr>
   <tr><td>DatePickerButtonBorderBrushPressed</td><td>Button border color when pressed</td></tr>
   <tr><td>DatePickerButtonBorderBrushDisabled</td><td>Button border color when disabled</td></tr>
   <tr><td>DateTimePickerFlyoutButtonForegroundPointerOver</td><td>Flyout button foreground color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonForegroundPressed</td><td>Flyout button foreground color when pressed</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackground</td><td>Flyout button background color at rest</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackgroundPointerOver</td><td>Flyout button background color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackgroundPressed</td><td>Flyout button background color when pressed</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrush</td><td>Flyout button border color at rest</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrushPointerOver</td><td>Flyout button border color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrushPressed</td><td>Flyout button border color when pressed</td></tr>
</table>

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Date picker](/windows/apps/design/controls/date-picker).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/DatePicker) or [**WinUI 2 Gallery**](winui2gallery:/item/DatePicker).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/p/winui-3-controls-gallery/9p3jfpwwdzrc) and the [**WinUI 2 Gallery**](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


This example shows how to create a simple date picker with a header.

```xaml
<DatePicker x:Name="birthDatePicker" Header="Date of birth"/>
```

```csharp
DatePicker birthDatePicker = new DatePicker()
{
    Header = "Date of birth"
};
```

## -see-also

[Date picker](/windows/apps/design/controls/date-picker), [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md), [System.DateTimeOffset (C#/VB)](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true), [Windows::Foundation::DateTime (C++)](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime), [Windows.Globalization.Calendar](../windows.globalization/calendar.md), [TimePicker](timepicker.md), [Controls list](/windows/apps/design/controls/)
