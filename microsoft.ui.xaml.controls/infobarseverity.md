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

[InfoBar.Severity](infobar_severity.md), [InfoBar overview](/windows/apps/design/controls/infobar)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [InfoBar](/windows/apps/design/controls/infobar).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/InfoBar) or [**WinUI 2 Gallery**](winui2gallery:/item/InfoBar).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).
