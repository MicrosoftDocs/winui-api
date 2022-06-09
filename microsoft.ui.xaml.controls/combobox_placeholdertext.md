---
-api-id: P:Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderText
-api-type: winrt property
---

<!-- Property syntax
public string PlaceholderText { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderText

## -description
Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ComboBox PlaceholderText="placeholderString"/>

```


## -xaml-values
<dl><dt>placeholderString</dt><dd>placeholderStringA text string that serves as placeholder content.</dd>
</dl>
## -property-value
The text that is displayed in the control when no value is selected. The default is an empty string ("").

## -remarks
The placeholder text is shown when the [SelectedIndex](../microsoft.ui.xaml.controls.primitives/selector_selectedindex.md) is -1 and the [SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md) is **null**. (These two properties are kept in sync.) A user can't display the placeholder text once an item has been selected. However, you can programmatically set either the [SelectedIndex](../microsoft.ui.xaml.controls.primitives/selector_selectedindex.md) to -1 or the [SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md) to **null** to cause the placeholder text to be shown again.

## -examples
Here's how to add placeholder text to a [ComboBox](combobox.md).

```xaml
<ComboBox Header="Colors" PlaceholderText="Pick a color">
    <x:String>Blue</x:String>
    <x:String>Green</x:String>
    <x:String>Red</x:String>
    <x:String>Yellow</x:String>
</ComboBox>

```



## -see-also
