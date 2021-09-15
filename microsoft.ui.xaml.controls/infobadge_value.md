---
-api-id: P:Microsoft.UI.Xaml.Controls.InfoBadge.Value
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.InfoBadge.Value

<!--
public int Value { get; set; }
-->


## -description
Gets or sets the integer to be displayed in a numeric InfoBadge.

## -property-value
Defaults to `-1`. 

## -remarks
There is no maximum value for this property, but values must be greater than or equal to zero.
Any value less than -1 will result in an argument error. A value of -1 is considered the null value. 

The InfoBadge will continue to stretch to display large numbers, so ensure that your layout accounts 
for that if you expect to have large values displayed in an InfoBadge.

## -see-also

## -examples

