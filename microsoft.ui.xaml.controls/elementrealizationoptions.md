---
-api-id: T:Microsoft.UI.Xaml.Controls.ElementRealizationOptions
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.ElementRealizationOptions

<!--
public enum ElementRealizationOptions
-->

## -description

Defines constants that specify whether to suppress automatic recycling of the retrieved element or force creation of a new element.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields

### -field ForceCreate

Creation of a new element is forced.

### -field None

No option is specified.

### -field SuppressAutoRecycle

The element is ignored by the automatic recycling logic.

## -remarks

When you call [GetOrCreateElementAt(index, options)](virtualizinglayoutcontext_getorcreateelementat_1708765960.md), you can specify whether to suppress automatic recycling of the retrieved element or force creation of a new element. Elements retrieved with automatic recycling suppressed (**SuppressAutoRecycle**) are ignored by the automatic recycling logic that clears realized elements that were not retrieved as part of the current layout pass. You must explicitly recycle these elements by passing them to the [RecycleElement](virtualizinglayoutcontext_recycleelement_37257770.md) method to avoid memory leaks.

## -see-also

[GetOrCreateElementAt(index, options)](virtualizinglayoutcontext_getorcreateelementat_1708765960.md)

## -examples

