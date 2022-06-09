---
-api-id: P:Microsoft.UI.Xaml.Controls.ProgressRing.IsActive
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ProgressRing.IsActive

<!--
public bool IsActive { get; set; }
-->


## -description
Gets or sets a value that indicates whether the [ProgressRing](progressring.md) is showing progress.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
**True** if the [ProgressRing](progressring.md) is showing progress; otherwise, **false**. The default is **false**. 

## -remarks
Set the IsActive property to turn the [ProgressRing](progressring.md) on or off. If IsActive is false, the [ProgressRing](progressring.md) is not shown, but space is reserved for it in the UI layout. To not reserve space for the [ProgressRing](progressring.md), set its [Visibility](/uwp/api/windows.ui.xaml.uielement.visibility) property to [Collapsed](/uwp/api/windows.ui.xaml.visibility).
