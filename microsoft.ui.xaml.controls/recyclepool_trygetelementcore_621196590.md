---
-api-id: M:Microsoft.UI.Xaml.Controls.RecyclePool.TryGetElementCore(System.String,Windows.UI.Xaml.UIElement)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected UIElement RecyclePool.TryGetElementCore(String key, UIElement owner)
-->

# Microsoft.UI.Xaml.Controls.RecyclePool.TryGetElementCore

## -description

Attempts to retrieve an element identified by the specified key. (This method provides the behavior when TryGetElement is called.)

## -parameters

### -param key

The identifier for the element.

### -param owner

The parent container for the element.

## -returns

The element identified by _key_ if it can be found; otherwise, **null**.

## -remarks

This method provides the behavior when [TryGetElement](/uwp/api/microsoft.ui.xaml.controls.recyclepool.trygetelement) is called. You can override this method in a derived class to provide custom behavior for TryGetElement.

## -see-also

## -examples

