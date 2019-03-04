---
-api-id: M:Microsoft.UI.Xaml.Controls.RecyclePool.TryGetElement(System.String,Windows.UI.Xaml.UIElement)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public UIElement RecyclePool.TryGetElement(String key, UIElement owner)
-->

# Microsoft.UI.Xaml.Controls.RecyclePool.TryGetElement

## -description

Attempts to retrieve an element identified by the specified key, with the specified owner.

## -parameters

### -param key

The identifier for the element.

### -param owner

The parent container for the element.

## -returns

The element identified by _key_ if it can be found; otherwise, **null**.

## -remarks

This method calls [TryGetElementCore](recyclepool_trygetelementcore_621196590.md). You can override TryGetElementCore in a derived class to provide custom behavior.

## -see-also

## -examples

