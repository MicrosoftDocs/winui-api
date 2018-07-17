---
-api-id: P:Microsoft.UI.Xaml.Controls.FontIconSource.MirroredWhenRightToLeft
-api-type: winrt property
---

<!-- Property syntax.
public bool MirroredWhenRightToLeft { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.FontIconSource.MirroredWhenRightToLeft

## -description

Gets or sets a value that indicates whether the icon is mirrored when its containing element's [FlowDirection](/uwp/api/windows.ui.xaml.frameworkelement.flowdirection) is **RightToLeft**.

## -xaml-syntax

```xaml
<FontIconSource MirroredWhenRightToLeft="bool"/>
```

## -property-value

**true** if the icon is mirrored when the [FlowDirection](/uwp/api/windows.ui.xaml.frameworkelement.flowdirection) is [FlowDirection.RightToLeft](/uwp/api/windows.ui.xaml.flowdirection); otherwise, **false**. The default is **false**.

## -remarks

You can set the [MirroredWhenRightToLeft](/uwp/api/windows.ui.xaml.controls.fonticon.mirroredwhenrighttoleft) property to have the glyph appear mirrored when its containing element's [FlowDirection](/uwp/api/windows.ui.xaml.frameworkelement.flowdirection) is [RightToLeft](/uwp/api/windows.ui.xaml.flowdirection). You typically use this property when a [FontIcon](/uwp/api/windows.ui.xaml.controls.fonticon) is used to display an icon as part of a control template and the icon needs to be mirrored along with the rest of the control.

## -see-also

## -examples

