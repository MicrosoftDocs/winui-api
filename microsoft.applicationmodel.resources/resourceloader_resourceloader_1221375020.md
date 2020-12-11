---
-api-id: M:Microsoft.ApplicationModel.Resources.ResourceLoader.#ctor
-api-type: winrt constructor
---

<!-- Method syntax
public ResourceLoader()
-->

# Microsoft.ApplicationModel.Resources.ResourceLoader.ResourceLoader

## -description

Constructs a new [ResourceLoader](resourceloader.md) object for the "Resources" subtree of the currently running app's main [ResourceMap](resourcemap.md).

## -remarks
The empty constructor typically allows access relative to a resource file's resources (resources.resjson or resources.resw).

This constructor fails with an exception if the main [ResourceMap](resourcemap.md) does not have a "Resources" subtree.

## -examples

## -see-also
- [ResourceLoader class](resourceloader.md)
- [ResourceLoader(String)](resourceloader_resourceloader_290278668.md)
- [ResourceMap](resourcemap.md)
