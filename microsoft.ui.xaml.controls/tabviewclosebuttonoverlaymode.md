---
-api-id: T:Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode

<!--
public enum TabViewCloseButtonOverlayMode
-->


## -description

Defines constants that describe the behavior of the close button contained within each TabViewItem. The default is Auto.

## -enum-fields

### -field Always

The selected tab always shows the close button if it is closable. Unselected tabs always show the close button if they are closable.

### -field Auto

Behavior is defined by the framework.

This value maps to **Always**.

### -field OnPointerOver

The selected tab always shows the close button if it is closable. Unselected tabs show the close button when the tab is closable and the user has their pointer over the tab. 

## -remarks

Selected TabViewItems that are closable always show their close button regardless of the value of the TabViewCloseButtonOverlayMode property. The TabViewCloseButtonOverlayMode only effects the behavior of the unselected TabViewItems. 

## -see-also

## -examples


