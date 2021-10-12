---
-api-id: P:Microsoft.UI.Input.PointerPointProperties.IsRightButtonPressed
-api-type: winrt property
---

# Microsoft.UI.Input.PointerPointProperties.IsRightButtonPressed

<!--
public bool IsRightButtonPressed { get; }
-->

## -description

Gets a value that indicates whether the pointer input was triggered by the secondary action mode (if supported) of an input device.

## -property-value

True if the secondary action mode. Otherwise, false.

## -remarks

Examples of secondary action modes when this property is set:

- A pen pointer when the pen tip is in contact with the digitizer surface and a modifying button, such as a barrel button (see [IsBarrelButtonPressed](pointerpointproperties_isbarrelbuttonpressed.md)), is pressed.
- A mouse pointer when the right mouse button is pressed.

A touch pointer does not set this property.

The eraser tip on a pen does not set this property (see [IsEraser](pointerpointproperties_iseraser.md)).

## -see-also

[IsLeftButtonPressed](pointerpointproperties_isleftbuttonpressed.md), [IsMiddleButtonPressed](pointerpointproperties_ismiddlebuttonpressed.md), [IsXButton1Pressed](pointerpointproperties_isxbutton1pressed.md), [IsXButton2Pressed](pointerpointproperties_isxbutton2pressed.md)

## -examples
