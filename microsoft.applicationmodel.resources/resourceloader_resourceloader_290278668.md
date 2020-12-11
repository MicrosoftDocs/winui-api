---
-api-id: M:Microsoft.ApplicationModel.Resources.ResourceLoader.#ctor(System.String)
-api-type: winrt constructor
---

<!-- Method syntax
public ResourceLoader(System.String name)
-->

# Microsoft.ApplicationModel.Resources.ResourceLoader.ResourceLoader

## -description

Constructs a new [ResourceLoader](resourceloader.md) object for the specified [ResourceMap](resourcemap.md).

## -parameters
### -param name
The resource identifier of the [ResourceMap](resourcemap.md) that the new resource loader uses for unqualified resource references. It can then retrieve resources relative to those references.

> [!NOTE]
> The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, "Caption%20" is treated as "Caption ". Do not use "?" or "#" in resource identifiers, as they terminate the resource path. For example, "Foo?3" is treated as "Foo".

## -remarks
This constructor is typically used to access resources relative to a resource file with the specified resource identifier. For example, `new ResourceLoader('Errors');` is relative to errors.resjson or errors.resw.

## -examples

## -see-also
- [ResourceLoader class](resourceloader.md)
- [ResourceLoader()](resourceloader_resourceloader_1221375020.md), 
- [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md)
