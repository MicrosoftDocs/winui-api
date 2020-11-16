---
-api-id: T:Microsoft.ApplicationModel.Resources.ResourceContext
-api-type: winrt class
---

# Microsoft.ApplicationModel.Resources.ResourceContext

<!--
public sealed class ResourceContext
-->

## -description

Encapsulates all of the factors ([ResourceQualifiers](resourcequalifiers.md)) that might affect resource selection.

## -remarks

Resources can be sensitive to scale, and different views owned by an app are able to display simultaneously on different display devices, which might use different scales. For that reason, a ResourceContext is generally associated with a specific view, and should be obtained using GetForCurrentView. (A view-independent ResourceContext can be obtained using GetForViewIndependentUse, but note that scale-dependent functionality will fail if invoked on a ResourceContext that is not associated with a view.)

Do not create an instance of ResourceContext using the constructor, as it is deprecated and subject to removal in a future release.

Except where otherwise noted, methods of this class can be called on any thread.

## -see-also

## -examples


