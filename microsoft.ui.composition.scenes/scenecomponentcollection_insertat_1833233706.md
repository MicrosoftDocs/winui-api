---
-api-id: M:Microsoft.UI.Composition.Scenes.SceneComponentCollection.InsertAt(System.UInt32,Microsoft.UI.Composition.Scenes.SceneComponent)
-api-type: winrt method
---

<!-- Method syntax.
public void SceneComponentCollection.InsertAt(UInt32 index, SceneComponent value)
-->

# Microsoft.UI.Composition.Scenes.SceneComponentCollection.InsertAt

## -description

Inserts the specified item at the specified index.

## -parameters
### -param index

The zero-based index at which to insert the item.

### -param value

The object to insert into the collection.

## -remarks

InsertAt expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -see-also

[SceneComponent](scenecomponent.md), [SceneNode.Components](scenenode_components.md)

## -examples

