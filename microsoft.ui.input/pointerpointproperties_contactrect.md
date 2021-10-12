---
-api-id: P:Microsoft.UI.Input.PointerPointProperties.ContactRect
-api-type: winrt property
---

# Microsoft.UI.Input.PointerPointProperties.ContactRect

<!--
public Windows.Foundation.Rect ContactRect { get; }
-->

## -description

Gets the bounding rectangle of the contact area (typically from touch input).

## -property-value

The bounding rectangle of the contact area, using client window coordinates in device-independent pixels (DIP).

## -remarks

ContactRect contains the bounding rectangle of the contact area as interpreted by the system. Under some circumstances, such as input prediction, this data can be modified by the system to compensate for hardware latency or message latency due to inherent delays in sensing and processing the pointer location on the digitizer.

See [ContactRectRaw](pointerpointproperties_contactrectraw.md) for more information on raw input data.

## -see-also

## -examples
