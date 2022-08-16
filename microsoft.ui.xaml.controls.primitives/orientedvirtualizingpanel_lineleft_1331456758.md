---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.LineLeft
-api-type: winrt method
---

<!-- Method syntax
public void LineLeft()
-->

# Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.LineLeft

## -description
Scrolls content by one line toward the left.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
This implementation calls [SetHorizontalOffset](orientedvirtualizingpanel_sethorizontaloffset_1971679761.md) using a value for "line" of 16 pixels, which comes from a default [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md).
<!-- Override the method and call <xref targtype="method_winrt" rid="w_ui_xaml_ctrl_prim.orientedvirtualizingpanel_sethorizontaloffset"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">SetHorizontalOffset</xref> using a different measurement to change the interpretation of "line" for a derivation of 
      <xref rid="w_ui_xaml_ctrl_prim.orientedvirtualizingpanel" targtype="class_winrt">OrientedVirtualizingPanel</xref>.-->

## -examples

## -see-also
