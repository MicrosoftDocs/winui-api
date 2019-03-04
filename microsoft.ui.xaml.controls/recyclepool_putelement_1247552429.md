---
-api-id: M:Microsoft.UI.Xaml.Controls.RecyclePool.PutElement(Windows.UI.Xaml.UIElement,System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void RecyclePool.PutElement(UIElement element, String key)
-->

# Microsoft.UI.Xaml.Controls.RecyclePool.PutElement

## -description

Adds an element to the recycle pool.

## -parameters
### -param element

The element to add to the recycle pool.

### -param key

The identifier for the element.

## -remarks

This method calls [PutElementCore](recyclepool_putelementcore_431763857.md) with a **null** owner value. You can override PutElementCore in a derived class to provide custom behavior.

## -see-also

## -examples

