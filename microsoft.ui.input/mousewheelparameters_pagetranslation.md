---
-api-id: P:Microsoft.UI.Input.MouseWheelParameters.PageTranslation
-api-type: winrt property
---

# Microsoft.UI.Input.MouseWheelParameters.PageTranslation

<!--
public Windows.Foundation.Point PageTranslation { get; set; }
-->

## -description

Gets or sets the conversion factors for both page width and height units, in device-independent pixel (DIP).

## -property-value

The conversion factors for the page width (x) and height (y).

## -remarks

The following image shows the default control panel settings for the button wheel. These settings map a single detent to a specific unit of distance in the UI (page width and height). PageTranslation provides the means to redefine these distances and specify the size of a page in terms of device-independent pixel (DIP).

:::image type="content" source="images/MouseProperties_ButtonWheel.png" alt-text="Mouse Properties dialog with wheel settings displayed":::
*Mouse Properties dialog with wheel settings displayed*

If the wheel button is set to scroll one screen (page) at a time for each detent and the value of PageTranslation is set to (1200,800), vertical scrolling is applied at 1 x 800 device-independent pixel (DIP) per detent. Horizontal scrolling distance through the mouse tilt wheel is dependent on the value of [CharTranslation](mousewheelparameters_chartranslation.md).

> [!NOTE]
> If **[ManipulationTranslateY](gesturesettings.md#-field-manipulationtranslatey-128)**/**[ManipulationTranslateRailsY](gesturesettings.md#-field-manipulationtranslaterailsy-512)**  is disabled and **[ManipulationTranslateX](gesturesettings.md#-field-manipulationtranslatex-64)**/**[ManipulationTranslateRailsX](gesturesettings.md#-field-manipulationtranslaterailsx-256)** is enabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the horizontal axis when the button wheel is rotated or tilted. Similarly, if **[ManipulationTranslateY](gesturesettings.md#-field-manipulationtranslatey-128)**/**[ManipulationTranslateRailsY](gesturesettings.md#-field-manipulationtranslaterailsy-512)** is enabled and **[ManipulationTranslateX](gesturesettings.md#-field-manipulationtranslatex-64)**/**[ManipulationTranslateRailsX](gesturesettings.md#-field-manipulationtranslaterailsx-256)** is disabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the vertical axis when the button wheel is rotated or tilted.

## -see-also

[GestureRecognizer.MouseWheelParameters](gesturerecognizer_mousewheelparameters.md), [CharTranslation](mousewheelparameters_chartranslation.md)

## -examples
