---
-api-id: P:Microsoft.UI.Xaml.Controls.TeachingTip.ShouldConstrainToRootBounds
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TeachingTip.ShouldConstrainToRootBounds

<!--
public bool ShouldConstrainToRootBounds { get; set; }
-->

## -description

Gets or sets a value that indicates whether the teaching tip will constrain to the bounds of its xaml root.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

## -remarks

If no placement option would allow a teaching tip to fully show, teaching tip will iterate through its event lifecycle to force a close rather than display without an accessible close button. If the app cancels the Closing event, the teaching tip may remain open without an accessible Close button.

## -see-also

## -examples

