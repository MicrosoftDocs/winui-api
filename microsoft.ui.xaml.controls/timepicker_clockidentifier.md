---
-api-id: P:Microsoft.UI.Xaml.Controls.TimePicker.ClockIdentifier
-api-type: winrt property
---

<!-- Property syntax
public string ClockIdentifier { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TimePicker.ClockIdentifier

## -description
Gets or sets the clock system to use.

## -xaml-syntax
```xaml
<TimePicker ClockIdentifier="12HourClock"/>
-or-
<TimePicker ClockIdentifier="24HourClock"/>
```


## -property-value
The name of the clock system to use. See Remarks.
## -remarks
The type of the property is **String**, but you must use values that correspond to the static string properties of [Windows.Globalization.ClockIdentifiers](/uwp/api/windows.globalization.clockidentifiers). These are: [TwelveHour](/uwp/api/windows.globalization.clockidentifiers.twelvehour) (the string "12HourClock")and [TwentyFourHour](/uwp/api/windows.globalization.clockidentifiers.twentyfourhour) (the string "24HourClock"). "12HourClock" is the default value.

<!--Valid strings are those returned by Windows.Globalization.ClockIdentifiers properties. In  code, best to use W.G.CI properties.-->

<!--List values-->

## -examples

## -see-also
[Windows.Globalization.ClockIdentifiers](/uwp/api/windows.globalization.clockidentifiers)
