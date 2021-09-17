---
-api-id: P:Microsoft.UI.Windowing.AppWindowTitleBar.LeftInset
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindowTitleBar.LeftInset

<!--
public int LeftInset { get; }
-->

## -description

Gets the width of the system-reserved region of the upper-left corner of the app window.

## -property-value

The width of the system-reserved region of the upper-left corner of the app window.

## -remarks

For applications with custom title bars (that is, [ExtendsContentIntoTitleBar](appwindowtitlebar_extendscontentintotitlebar.md) is `true`), the system reserves the option to have system UI drawn in the upper-left or upper-right corner of the app window. The system draws caption buttons in the upper-right for left-to-right languages and the upper-left for right-to-left languages.

The width of the reserved region on each side is given by `LeftInset` or [RightInset](appwindowtitlebar_rightinset.md) properties, and its height is given by the [Height](appwindowtitlebar_height.md) property. In the areas described by these regions, you should not put any UI that you expect the user to be able to interact with.

This property has the value of 0 if `ExtendsContentIntoTitleBar` is `false` or if there is no occlusion of the client area by this inset.

## -see-also

[AppWindowTitleBar](appwindowtitlebar.md)

## -examples
