---
-api-id: T:Microsoft.ApplicationModel.Resources.ResourceLoader
-api-type: winrt class
---

<!-- Class syntax.
public class ResourceLoader : Windows.ApplicationModel.Resources.IResourceLoader, Windows.ApplicationModel.Resources.IResourceLoader2
-->

# Microsoft.ApplicationModel.Resources.ResourceLoader

## -description
Provides simplified access to app resources such as app UI strings.

## -remarks
A **ResourceLoader** object encapsulates a particular [ResourceMap](/uwp/api/windows.applicationmodel.resources.core.resourcemap) and a [ResourceContext](/uwp/api/windows.applicationmodel.resources.core.resourcecontext), combined in a simple API.

A specific resource map can be specified when the **ResourceLoader** is obtained; if no resource map is specified, the **ResourceLoader** will provide access to the "Resources" subtree of the app's main resource map.

In general, resources can be sensitive to scale or other display characteristics. For that reason, resource contexts are generally associated with a specific view. Since a **ResourceLoader** encapsulates a resource context, this also applies to a **ResourceLoader**.

+ Obtain the scale factor for the current view by using the [DisplayInformation](/uwp/api/windows.graphics.display.displayinformation) class instead of the deprecated [DisplayProperties](/uwp/api/windows.graphics.display.displayproperties) class.
+ Apps that set explicit width and height of elements should still work fine, other than possibly displaying blurry images.
+ Obtain resources that are not associated with any view by getting a **ResourceLoader** via [GetForViewIndependentUse](resourceloader_getforviewindependentuse_1317372352.md).

Also see [Screen sizes and breakpoints](/windows/uwp/design/layout/screen-sizes-and-breakpoints-for-responsive-design).
