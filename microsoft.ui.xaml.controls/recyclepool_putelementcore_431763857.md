---
-api-id: M:Microsoft.UI.Xaml.Controls.RecyclePool.PutElementCore(Windows.UI.Xaml.UIElement,System.String,Windows.UI.Xaml.UIElement)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected void RecyclePool.PutElementCore(UIElement element, String key, UIElement owner)
-->

# Microsoft.UI.Xaml.Controls.RecyclePool.PutElementCore

## -description

Adds an element to the recycle pool with the specified owner. (This method provides the behavior when PutElement is called.)

## -parameters

### -param element

The element to add to the recycle pool.

### -param key

The identifier for the element.

### -param owner

The parent container for the element.

## -remarks

This method provides the behavior when [PutElement](/uwp/api/microsoft.ui.xaml.controls.recyclepool.putelement) is called. You can override this method in a derived class to provide custom behavior for PutElement.

## -see-also

## -examples

