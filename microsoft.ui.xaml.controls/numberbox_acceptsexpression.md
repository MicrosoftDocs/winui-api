---
-api-id: P:Microsoft.UI.Xaml.Controls.NumberBox.AcceptsExpression
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NumberBox.AcceptsExpression

<!--
public bool AcceptsExpression { get; set; }
-->

## -description

Toggles whether the control will accept and evaluate a basic formulaic expression entered as input.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

## -remarks

NumberBox uses infix notation to evaluate expressions. In order of precedence, the allowable operators are:

- ^
- */
- +-

Note that parentheses can be used to override precedence rules.

## -see-also

## -examples

