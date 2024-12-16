---
-api-id: P:Microsoft.UI.Xaml.Controls.NumberBox.AcceptsExpression
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NumberBox.AcceptsExpression

<!--
public bool AcceptsExpression { get; set; }
-->

## -description

Gets or sets a value that indicates whether the control accepts and evaluates a basic formulaic expression entered as input.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

`true` if the NumberBox accepts and evaluates a basic formulaic expression entered as input; otherwise, `false`. The default is `false`.

## -remarks

NumberBox uses infix notation to evaluate expressions. In order of precedence, the allowable operators are:

- ^
- */
- +-

Parentheses can be used to override precedence rules.

## -see-also

[Number box](/windows/apps/design/controls/number-box)

## -examples
