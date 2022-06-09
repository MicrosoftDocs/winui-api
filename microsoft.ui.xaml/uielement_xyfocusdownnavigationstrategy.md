---
-api-id: P:Microsoft.UI.Xaml.UIElement.XYFocusDownNavigationStrategy
-api-type: winrt property
---

<!-- Property syntax.
public XYFocusNavigationStrategyMode XYFocusDownNavigationStrategy { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.XYFocusDownNavigationStrategy

## -description

Gets or sets a value that specifies the strategy used to determine the target element of a down navigation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<uiElement XYFocusDownNavigationStrategy="xyFocusNavigationStrategyMemberName"/>
```

## -xaml-values

***xyFocusNavigationStrategyMemberName***

One of the named constants of the [XYFocusNavigationStrategy](../microsoft.ui.xaml.input/xyfocusnavigationstrategy.md) enumeration.

## -property-value

A value of the enumeration. The default is **Auto**.

## -remarks

When this property is set to **Auto**, the strategy is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**.  

## -see-also

[XYFocusNavigationStrategy](../microsoft.ui.xaml.input/xyfocusnavigationstrategy.md)

## -examples

