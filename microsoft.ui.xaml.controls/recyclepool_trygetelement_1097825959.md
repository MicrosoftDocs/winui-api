---
-api-id: M:Microsoft.UI.Xaml.Controls.RecyclePool.TryGetElement(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public UIElement RecyclePool.TryGetElement(String key)
-->

# Microsoft.UI.Xaml.Controls.RecyclePool.TryGetElement

## -description

Attempts to retrieve an element identified by the specified key.

## -parameters

### -param key

The identifier for the element.

## -returns

The element identified by _key_ if it can be found; otherwise, **null**.

## -remarks

This method calls [TryGetElementCore](recyclepool_trygetelementcore_621196590.md) with a **null** owner value. You can override TryGetElementCore in a derived class to provide custom behavior.

## -see-also

## -examples

