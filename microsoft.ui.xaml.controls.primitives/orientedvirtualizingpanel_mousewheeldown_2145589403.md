---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.MouseWheelDown
-api-type: winrt method
---

<!-- Method syntax
public void MouseWheelDown()
-->

# Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel.MouseWheelDown

## -description
Scrolls content by one mouse-wheel click toward the bottom.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
This implementation calls [SetVerticalOffset](orientedvirtualizingpanel_setverticaloffset_1333703417.md) using a default value for "mouse-wheel click" of 48 pixels (3 lines), which comes from a default [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md). 
<!--Override the method and call <xref targtype="method_winrt" rid="w_ui_xaml_ctrl_prim.orientedvirtualizingpanel_setverticaloffset"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">SetVerticalOffset</xref> using a different measurement to change the interpretation of "mousewheel click" for a derivation of 
      <xref rid="w_ui_xaml_ctrl_prim.orientedvirtualizingpanel" targtype="class_winrt">OrientedVirtualizingPanel</xref>.-->

## -examples

## -see-also
