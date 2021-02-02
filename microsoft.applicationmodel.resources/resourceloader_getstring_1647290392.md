---
-api-id: M:Microsoft.ApplicationModel.Resources.ResourceLoader.GetString(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetString(System.String resourceId)
-->

# Microsoft.ApplicationModel.Resources.ResourceLoader.GetString

## -description
Returns the most appropriate string value of a resource, specified by resource identifier.


<!--Writer todo: Link to how to create and identify resources.-->

## -parameters
### -param resourceId
The resource identifier of the resource to be resolved.

> [!NOTE]
> The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, **getString** ("Caption%20") is treated as **getString** ("Caption "). Do not use "?" or "#" in resource identifiers, as they terminate the resource path. For example, "Foo?3" is treated as "Foo".

## -returns
The most appropriate string value of the specified resource for the default [ResourceContext](resourcecontext.md).

## -remarks
<!--Writer todo: remarks: discuss when to use GetString vs. GetStringByReference.-->

## -examples
See the example in [ResourceLoader](resourceloader.md).

## -see-also
[ResourceContext](resourcecontext.md)
