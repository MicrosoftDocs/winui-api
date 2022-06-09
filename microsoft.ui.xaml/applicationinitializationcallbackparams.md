---
-api-id: T:Microsoft.UI.Xaml.ApplicationInitializationCallbackParams
-api-type: winrt class
---

<!-- Class syntax.
public class ApplicationInitializationCallbackParams : Windows.UI.Xaml.IApplicationInitializationCallbackParams
-->

# Microsoft.UI.Xaml.ApplicationInitializationCallbackParams

## -description
A class that developers should derive from in order to pass information for a custom initialization sequence, in cases where both an [Application](application.md) subclass is present and the entry point [Start](application_start_1265583819.md) call is adjusted to pass the information.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
This class is used as a custom information source for an [ApplicationInitializationCallback](applicationinitializationcallback.md) implementation. The basic ApplicationInitializationCallbackParams does not have any unique members. Your subclass should add any members you need for initialization information.

## -examples

## -see-also
[Application](application.md), [ApplicationInitializationCallback](applicationinitializationcallback.md)
