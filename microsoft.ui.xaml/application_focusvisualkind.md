---
-api-id: P:Microsoft.UI.Xaml.Application.FocusVisualKind
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.FocusVisualKind FocusVisualKind { get;  set; }
-->

# Microsoft.UI.Xaml.Application.FocusVisualKind

## -description
Gets or sets the type of visual feedback that an app can use to indicate the UI element with focus.

> This property is valid only for input devices that can generate key events, such as a keyboard or Xbox controller.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The type of visual feedback used to indicate the UI element with focus. The default value depends on the operating system.

> **Windows 10, version 1607 and later**
> [HighVisibility](focusvisualkind.md)

> **All previous versions**
> [DottedLine](focusvisualkind.md)

## -remarks
[HighVisibility](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border. 
For more info:

+ [FocusVisualPrimaryBrush](frameworkelement_focusvisualprimarybrush.md)
+ [FocusVisualSecondaryBrush](frameworkelement_focusvisualsecondarybrush.md)
+ [FocusVisualPrimaryThickness](frameworkelement_focusvisualprimarythickness.md)
+ [FocusVisualSecondaryThickness](frameworkelement_focusvisualsecondarythickness.md)


## -examples

## -see-also
