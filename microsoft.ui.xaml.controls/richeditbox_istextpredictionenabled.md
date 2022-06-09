---
-api-id: P:Microsoft.UI.Xaml.Controls.RichEditBox.IsTextPredictionEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsTextPredictionEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichEditBox.IsTextPredictionEnabled

## -description
Gets or sets a value that indicates whether text prediction features ("autocomplete") are enabled for this [RichEditBox](richeditbox.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<RichEditBox IsTextPredictionEnabled="bool" />
```


## -property-value
**True** to enable text prediction features; otherwise, **false**. The default is **true**.

## -remarks
This property doesn't affect Input Method Editor (IME) for Japanese or Chinese languages. Text prediction for these languages is shown even if this property is **false**.

## -examples

## -see-also
