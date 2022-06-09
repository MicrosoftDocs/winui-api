---
-api-id: E:Microsoft.UI.Xaml.UIElement.NoFocusCandidateFound
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler NoFocusCandidateFound<UIElement, NoFocusCandidateFoundEventArgs>
-->

# Microsoft.UI.Xaml.UIElement.NoFocusCandidateFound

## -description

Occurs when a user attempts to move focus (via tab or directional arrows), but focus doesn't move because no focus candidate is found in the direction of movement.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<uiElement NoFocusCandidateFound="eventhandler"/>
```

## -remarks

NoFocusCandidateFound is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -see-also

[NoFocusCandidateFoundEventArgs](../microsoft.ui.xaml.input/nofocuscandidatefoundeventargs.md)

## -examples
