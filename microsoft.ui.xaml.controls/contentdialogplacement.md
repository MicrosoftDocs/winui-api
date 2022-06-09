---
-api-id: T:Microsoft.UI.Xaml.Controls.ContentDialogPlacement
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ContentDialogPlacement : int 
-->

# Microsoft.UI.Xaml.Controls.ContentDialogPlacement

## -description

Defines constants that specify where in the XAML visual tree a ContentDialog is rooted.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field Popup:0

The dialog is rooted in the PopupRoot element of the XAML Window.

### -field InPlace:1

If the dialog has a parent element, the dialog is rooted in the parent's visual tree. Otherwise, it falls back to the **Popup** behavior.

## -remarks

## -see-also

## -examples

