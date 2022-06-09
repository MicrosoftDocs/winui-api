---
-api-id: T:Microsoft.UI.Xaml.TriggerBase
-api-type: winrt class
---

<!-- Class syntax.
public class TriggerBase : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.ITriggerBase
-->

# Microsoft.UI.Xaml.TriggerBase

## -description
Serves as the base class for [EventTrigger](eventtrigger.md). Not commonly used. See Remarks.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
[Triggers](frameworkelement_triggers.md), [EventTrigger](eventtrigger.md), [Actions](eventtrigger_actions.md) and [BeginStoryboard](../microsoft.ui.xaml.media.animation/beginstoryboard.md) are not commonly used. These API mainly exist for compatibility in XAML originally used for Microsoft Silverlight. For most scenarios where event triggers were used previously, you should either use visual states, or start animations by writing a [Loaded](frameworkelement_loaded.md) handler that looks up an animation in page-level resources and then calls [Begin](../microsoft.ui.xaml.media.animation/storyboard_begin_1621727531.md) on the animation's main [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md). For more info, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)) or [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

## -examples

## -see-also
[Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md)
