---
-api-id: T:Microsoft.ApplicationModel.Resources.ResourceMap
-api-type: winrt class
---

# Microsoft.ApplicationModel.Resources.ResourceMap

<!--
public sealed class ResourceMap
-->


## -description

A collection of related resources, typically either for a particular app package, or a resource file for a particular package.

## -remarks

### Resource identifier syntax

Many methods of this class use resource identifiers as parameters. The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, GetValue("Caption%20") is treated as GetValue("Caption ").

Do not use "?" or "#" in resource identifiers, because they terminate the resource path evaluation. For example, "MyResource?3" is treated as "MyResource".

## -see-also

## -examples


