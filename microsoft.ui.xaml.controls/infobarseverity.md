---
-api-id: T:Microsoft.UI.Xaml.Controls.InfoBarSeverity
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.InfoBarSeverity

<!--
public enum InfoBarSeverity
-->


## -description

Defines constants that indicate the criticality of the [InfoBar](infobar.md) that is shown.

## -enum-fields

### -field Informational:0

Communicates that the InfoBar is displaying general information that requires the user's attention. For assistive technologies, they will follow the behavior set in the Processing_All constant.

### -field Success:1

Communicates that the InfoBar is displaying information regarding a long-running and/or background task that has completed successfully. For assistive technologies, they will follow the behavior set in the Processing_All constant.

### -field Warning:2

Communicates that the InfoBar is displaying information regarding a condition that might cause a problem in the future. For assistive technologies, they will follow the behavior set in the NotificationProcessing_ImportantAll constant.

### -field Error:3

Communicates that the InfoBar is displaying information regarding an error or problem that has occurred. For assistive technologies, they will follow the behavior set in the NotificationProcessing_ImportantAll constant.

## -remarks

## -see-also

[InfoBar.Severity](infobar_severity.md), [InfoBar overview](/windows/uwp/design/controls-and-patterns/infobar)

## -examples
See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [InfoBar](xamlcontrolsgallery:/item/InfoBar) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).

