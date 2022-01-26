---
-api-id: M:Microsoft.UI.Xaml.Controls.XamlControlsResources.EnsureRevealLights(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.XamlControlsResources.EnsureRevealLights(Microsoft.UI.Xaml.UIElement)

<!--
public static void EnsureRevealLights (Microsoft.UI.Xaml.UIElement element);
-->

## -description

> [!Important]
> EnsureRevealLights is available for use in the operating systems specified in the Requirements section. However, we do not recommend its use as it may be altered or unavailable in subsequent versions.

Ensures that ambient and border lights required for reveal effects are set on the specified element.

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
