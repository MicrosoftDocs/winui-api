---
-api-id: T:Microsoft.UI.Xaml.FlowDirection
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FlowDirection : int
-->

# FlowDirection

## -description

Defines constants that specify the content flow direction for text and UI elements.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<object property="enumMemberName"/>
 
```

## -enum-fields

### -field LeftToRight:0

Indicates that content should flow from left to right.

### -field RightToLeft:1

Indicates that content should flow from right to left.

## -remarks

The FlowDirection enumeration is used as a value by the [FrameworkElement.FlowDirection](frameworkelement_flowdirection.md) property. **LeftToRight** is the default value.

[FrameworkElement.FlowDirection](frameworkelement_flowdirection.md) is interpreted differently for render purposes depending on which [FrameworkElement](frameworkelement.md) subclass is involved as the content or as a container. For more info, see [FrameworkElement.FlowDirection](frameworkelement_flowdirection.md).

## -examples

## -see-also

[FrameworkElement.FlowDirection](frameworkelement_flowdirection.md), [How to adjust layout and fonts for various languages, and support RTL layouts](/previous-versions/windows/apps/hh967760(v=win.10))
