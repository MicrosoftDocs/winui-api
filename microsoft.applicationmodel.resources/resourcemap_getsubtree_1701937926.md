---
-api-id: M:Microsoft.ApplicationModel.Resources.ResourceMap.GetSubtree(System.String)
-api-type: winrt method
---

# Microsoft.ApplicationModel.Resources.ResourceMap.GetSubtree(System.String)

<!--
public Microsoft.ApplicationModel.Resources.ResourceMap GetSubtree (string reference);
-->


## -description

Returns a [ResourceMap](resourcemap.md) that represents a part of another ResourceMap, typically used to access a particular resource file within an app package.

This method finds subtree, ancestor, sibling and cousin maps to this resource map, as well as top-level maps. It returns the resource map represented by a given resource map identifier, relative to this resource map. This method is typically used to make simpler references to a particular subset of resources, such as a single resource file, or a directory of files.

## -parameters

### -param reference

A resource map identifier that identifies the root of the new subtree. For details, see the remarks for [ResourceMap](resourcemap.md) class.

## -returns

The subtree [ResourceMap](resourcemap.md).

## -remarks

## -see-also

## -examples


