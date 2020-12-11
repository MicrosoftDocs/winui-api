---
-api-id: M:Microsoft.ApplicationModel.Resources.ResourceMap.GetValue(System.String,Microsoft.ApplicationModel.Resources.ResourceContext)
-api-type: winrt method
---

# Microsoft.ApplicationModel.Resources.ResourceMap.GetValue(System.String,Microsoft.ApplicationModel.Resources.ResourceContext)

<!--
public Microsoft.ApplicationModel.Resources.ResourceCandidate GetValue (string resource, Microsoft.ApplicationModel.Resources.ResourceContext context);
-->


## -description

Returns the most appropriate candidate for a resource that is specified by a resource identifier for the supplied context.

## -parameters

### -param resource

A resource specified as a name or reference. For details, see the remarks for ResourceMap class.

### -param context

The context for which to select the most appropriate candidate.

## -returns

A [ResourceCandidate](resourcecandidate.md) that describes the most appropriate candidate.

## -remarks

Some resources are loaded according to the scale of the view where they will be displayed, and different views within an app might be displayed on different devices with different scales. Scale is a per-view characteristic.

Since the GetValue method selects the best candidate for the specified resource in relation to a runtime context, and since the scale qualifier of a ResourceContext depends on the associated view, GetValue should always be called with a ResourceContext object obtained from the view in which the resource will be used.

## -see-also

## -examples


