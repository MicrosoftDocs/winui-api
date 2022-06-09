---
-api-id: P:Microsoft.UI.Xaml.UIElement.XYFocusKeyboardNavigation
-api-type: winrt property
---

<!-- Property syntax.
public XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.XYFocusKeyboardNavigation

## -description

Gets or sets a value that enables or disables navigation using the keyboard directional arrows.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<uiElement XYFocusKeyboardNavigation="xyFocusKeyboardNavigationModeMemberName"/>
```

## -xaml-values

***xyFocusKeyboardNavigationModeMemberName***

One of the named constants of the [XYFocusKeyboardNavigationMode](../microsoft.ui.xaml.input/xyfocuskeyboardnavigationmode.md) enumeration.

## -property-value

A value of the enumeration. The default is **Auto**.

## -remarks

When this property is set to **Auto**, the behavior is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback behavior is **Disabled**.  

## -see-also

[XYFocusKeyboardNavigationMode](../microsoft.ui.xaml.input/xyfocuskeyboardnavigationmode.md)

## -examples

