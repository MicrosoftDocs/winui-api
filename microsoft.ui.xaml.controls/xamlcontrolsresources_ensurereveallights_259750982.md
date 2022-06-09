---
-api-id: M:Microsoft.UI.Xaml.Controls.XamlControlsResources.EnsureRevealLights(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlControlsResources.EnsureRevealLights(UIElement element)
-->

# Microsoft.UI.Xaml.Controls.XamlControlsResources.EnsureRevealLights

## -description

> [!Important]
> EnsureRevealLights is available for use in the operating systems specified in the Requirements section. However, we do not recommend its use as it may be altered or unavailable in subsequent versions.

Ensures that ambient and border lights required for reveal effects are set on the specified element.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param element

The element that requires lighting for reveal effects.

## -remarks

Typically, lights required for reveal effects are attached automatically but, in some cases, lights can be lost or might never be connected. Call this method to ensure they are connected.

This method can be called multiple times as lights will only be attached once.

Examples where this method might need calling include the following:

1. Reveal on full window media controls (pass the MediaTransportControls instance).
2. App sets Window.Content, which destroys the RootScrolLViewer lights (pass any element in the main tree).

## -see-also

## -examples
