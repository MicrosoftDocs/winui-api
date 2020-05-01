---
-api-id: P:Microsoft.UI.Xaml.Controls.NumberBox.Text
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NumberBox.Text

<!--
public string Text { get; set; }
-->

## -description

Gets or sets the string type representation of the [Value](numberbox_value.md) property. 

## -property-value

## -remarks

This property exists to faciliate getting the string representation of [Value](numberbox_value.md)'s numeric contents without the need for type conversion. Note the content of [Value](numberbox_value.md) will overwrite the content of this property in initial set up. After the initial set up, changes to one will be progrogated to the other, but consistently making programmatic changes through [Value](numberbox_value.md) helps avoid any conceptual misunderstanding that [NumberBox](numberbox.md) will accept non-numeric characters through this property.

## -see-also

## -examples

