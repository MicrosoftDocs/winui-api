---
-api-id: P:Microsoft.UI.Xaml.Controls.TeachingTip.PreferredPlacement
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TeachingTip.PreferredPlacement

<!--
public Microsoft.UI.Xaml.Controls.TeachingTipPlacementMode PreferredPlacement { get; set; }
-->

## -description

Preferred placement to be used for the teaching tip. If there is not enough space to show at the preferred placement, a new placement will be automatically chosen. 
Placement is relative to its target if Target is non-null or to the parent window of the teaching tip if Target is null.

## -property-value

## -remarks

Teaching tip replicates Flyout's [FlyoutPlacementMode](/uwp/api/Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode) placement behavior with the TeachingTipPlacementMode property. The default placement mode will try to place a targeted teaching tip above its target and a non-targeted teaching tip centered at the bottom of the xaml root. As with Flyout, if the preferred placement mode would not leave room for the teaching tip to show, another placement mode will be automatically chosen. 

If you anticipate that your app will be used with gamepad input, please see [gamepad and remote control interactions](/windows/apps/design/input/gamepad-and-remote-interactions#xy-focus-navigation-and-interaction). It is encouraged to test gamepad accessibility of each teaching tip using all possible configurations of an app's UI.

## -see-also

## -examples

