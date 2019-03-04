---
-api-id: T:Microsoft.UI.Xaml.Controls.FlowLayout
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class FlowLayout : VirtualizingLayoutBase, VirtualizingLayoutBase
-->

# Microsoft.UI.Xaml.Controls.FlowLayout

## -description

Represents a layout that stacks lines of items. When a line of items is full, items flow to the next line.

## -remarks

Flow layouts can be described as a virtualizing stack layout of non-virtualizing stack layouts of opposite directions. A flow layout has a set of rules and policies that:

- Determine the measure and arrange size of the containers. 
- Break lines and flow from one inner stack layout to another. 
- Distribute empty space in a line.
- Horizontally align lines and vertically align the containers in a line.

FlowLayout supports virtualization when attached to a host that supports virtualization.

## -see-also

## -examples

