---
-api-id: T:Microsoft.ApplicationModel.Resources.ResourceCandidateKind
-api-type: winrt enum
---

# Microsoft.ApplicationModel.Resources.ResourceCandidateKind

<!--
public enum ResourceCandidateKind
-->
## -description

Defines values that represent the type of resource that is encapsulated in a [ResourceCandidate](resourcecandidate.md).

## -enum-fields

### -field Unknown:0

The ResourceCandiate contains a value with an unknown type.

### -field String:1

The resource is a string.

### -field FilePath:2

The resource is a file located at the specified location.

### -field EmbeddedData:3

The resource is embedded data in some containing resource file (such as a .resw file).

## -remarks

Note that the enum values are different than those in [Windows.ApplicationModel.Resources.Core.ResourceCandidateKind](https://docs.microsoft.com/en-us/uwp/api/windows.applicationmodel.resources.core.resourcecandidatekind).

## -see-also

## -examples


