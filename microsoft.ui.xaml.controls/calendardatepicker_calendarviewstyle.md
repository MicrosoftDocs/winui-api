---
-api-id: P:Microsoft.UI.Xaml.Controls.CalendarDatePicker.CalendarViewStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style CalendarViewStyle { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.CalendarDatePicker.CalendarViewStyle

## -description
Gets or sets the [Style](../microsoft.ui.xaml/style.md) associated with the control's internal [CalendarView](calendarview.md) object.

## -xaml-syntax
```xaml

<CalendarDatePicker CalendarViewStyle={StaticResource styleResourceKey}/>
- or -
<CalendarDatePicker>
  <CalendarDatePicker.CalendarViewStyle>
    <Style TargetType="CalendarView">
      oneOrMoreSetters
    </Style>
  </CalendarDatePicker.CalendarViewStyle>
</CalendarDatePicker>
```


## -xaml-values
<dl><dt>styleResourceKey</dt><dd>styleResourceKeyThe key that identifies the style being requested. The key refers to an existing resource in a ResourceDictionary.</dd>
<dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more Setter elements with Property attributes that target the dependency properties of the CalendarView component of the CalendarDatePicker template.</dd>
</dl>
## -property-value
The current style of the [CalendarView](calendarview.md) object.

## -remarks

## -examples

## -see-also
