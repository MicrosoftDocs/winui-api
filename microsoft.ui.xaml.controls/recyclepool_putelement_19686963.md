---
-api-id: M:Microsoft.UI.Xaml.Controls.RecyclePool.PutElement(Windows.UI.Xaml.UIElement,System.String,Windows.UI.Xaml.UIElement)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void RecyclePool.PutElement(UIElement element, String key, UIElement owner)
-->

# Microsoft.UI.Xaml.Controls.RecyclePool.PutElement

## -description

Adds an element to the recycle pool with the specified owner.

## -parameters

### -param element

The element to add to the recycle pool.

### -param key

The identifier for the element.

### -param owner

The parent container for the element.

## -remarks

Using elements from the same owner is preferred because it avoids removing the element from its previous parent and then adding it again to the visual tree under its new parent. Removing and adding elements in the visual tree is an expensive operation, so it's beneficial to avoid or delay that as much as possible.

This method calls [PutElementCore](recyclepool_putelementcore_431763857.md). You can override PutElementCore in a derived class to provide custom behavior.

## -see-also

## -examples

