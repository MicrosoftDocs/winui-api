---
-api-id: P:Microsoft.UI.Xaml.Controls.ComboBox.IsEditable
-api-type: winrt property
---

<!-- Property syntax
public bool IsEditable { get; }
-->

# Microsoft.UI.Xaml.Controls.ComboBox.IsEditable

## -description

Gets or sets a value that indicates whether the user can edit text in the text box portion of the [ComboBox](combobox.md). See remarks.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<ComboBox IsEditable="bool"/>

```

## -property-value

**true** if the user can edit text in the ComboBox, otherwise **false**. The default is **false**. See remarks.

## -remarks

> [!IMPORTANT]
> The behavior of this property is changed in Windows 10, version 1809 (SDK 17763). In earlier versions of Windows, this property is read-only and always returns **false**.

For more info, see [Make a combo box editable](/windows/apps/design/controls/combo-box#make-a-combo-box-editable).

## -examples

## -see-also
