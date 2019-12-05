---
-api-id: P:Microsoft.UI.Xaml.Controls.NumberBox.Value
-api-type: winrt property
---

## -description

Gets or sets the numeric value of a [NumberBox](numberbox.md).

## -property-value

## -remarks

[Text](numberbox_text.md) exists to faciliate getting the string representation of this property's numeric contents without the need for type conversion. Note the content of this property will overwrite the content of [Text](numberbox_text.md) in initial set up. After the initial set up, changes to one will be progrogated to the other, but consistently making programmatic changes through this property helps avoid any conceptual misunderstanding that [NumberBox](numberbox.md) will accept non-numeric characters through the [Text](numberbox_text.md) property.

## -see-also

## -examples

