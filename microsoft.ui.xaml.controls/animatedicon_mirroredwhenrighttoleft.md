---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedIcon.MirroredWhenRightToLeft
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.AnimatedIcon.MirroredWhenRightToLeft

<!--
public bool MirroredWhenRightToLeft { get; set; }
-->

## -description

Gets or sets a value that indicates whether the icon is mirrored when the [FlowDirection](/uwp/api/windows.ui.xaml.frameworkelement.flowdirection) is **RightToLeft**.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

True, if the icon is mirrored when the [FlowDirection](/uwp/api/windows.ui.xaml.frameworkelement.flowdirection) is **RightToLeft**. Otherwise, false. The default is false.

## -remarks

You can set the [MirroredWhenRightToLeft](animatedicon_mirroredwhenrighttoleft.md) property to have the glyph appear mirrored when the [FlowDirection](/uwp/api/windows.ui.xaml.frameworkelement.flowdirection) is **RightToLeft**. You typically use this property when an AnimatedIcon is used as part of a control template and the icon needs to be mirrored along with the rest of the control.

## -see-also

[FlowDirection](/uwp/api/windows.ui.xaml.frameworkelement.flowdirection), [Design your app for bidirectional text](/windows/apps/design/globalizing/design-for-bidi-text), [Adjust layout and fonts, and support RTL](/windows/apps/design/globalizing/adjust-layout-and-fonts--and-support-rtl)

## -examples
