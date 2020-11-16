---
-api-id: M:Microsoft.UI.Xaml.Controls.SwapChainPanel.CreateCoreIndependentInputSource(Windows.UI.Core.CoreInputDeviceTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Core.CoreIndependentInputSource CreateCoreIndependentInputSource(Windows.UI.Core.CoreInputDeviceTypes deviceTypes)
-->

# Microsoft.UI.Xaml.Controls.SwapChainPanel.CreateCoreIndependentInputSource

## -description
Creates a core input object that handles the input types as specified by the *deviceTypes* parameter. This core input object can process input events on a background thread.

## -parameters
### -param deviceTypes
A combined value of the enumeration.

## -returns
An object that represents the input subsystem for interoperation purposes and can be used for input event connection points.

## -remarks
This method enables an app that includes a [SwapChainPanel](swapchainpanel.md) to handle input and rendering independent of the XAML UI thread, because you're deliberately providing the input processing logic on a background thread. You must call CreateCoreIndependentInputSource from a non-UI thread, otherwise this method will fail.

Use the [CreateCoreIndependentInputSource](swapchainbackgroundpanel_createcoreindependentinputsource_467679991.md) method to create a core input object and associate it with your [SwapChainPanel](swapchainpanel.md). Upon successful creation, user input of the specified device types that accesses [SwapChainPanel](swapchainpanel.md) contents will be redirected to the thread that CreateCoreIndependentInputSource was called from. Your app can handle this input by registering for input events and processing those events on a background thread. In order to receive input messages through the [CoreIndependentInputSource](/uwp/api/windows.ui.core.coreindependentinputsource) object, the app code must set a swap chain on the [SwapChainPanel](swapchainpanel.md), and render (at a Microsoft DirectX level) from this swap chain at least once. That provides the rendering that makes hit testing possible.

You typically use [CoreDispatcher.ProcessEvents](/uwp/api/windows.ui.core.coredispatcher.processevents(windows.ui.core.coreprocesseventsoption)) as part of the event handling. Get a [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) reference from [CoreIndependentInputSource.Dispatcher](/uwp/api/windows.ui.core.coreindependentinputsource.dispatcher). For more info on how to use background threads, see [ThreadPool](/uwp/api/windows.system.threading.threadpool) or [Threading and async programming](/windows/uwp/threading-async/index).

You can call CreateCoreIndependentInputSource multiple times. Each time CreateCoreIndependentInputSource is called, the previous [CoreIndependentInputSource](/uwp/api/windows.ui.core.coreindependentinputsource) object is disassociated with the [SwapChainPanel](swapchainpanel_swapchainpanel_1221375020.md). In other words, only one [CoreIndependentInputSource](/uwp/api/windows.ui.core.coreindependentinputsource) object can get events at a time.

For example code of how to use CreateCoreIndependentInputSource, see the `DrawingPanel` class definition that is part of the [XAML SwapChainPanel DirectX interop sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20SwapChainPanel%20DirectX%20interop%20sample).

CreateCoreIndependentInputSource d can return **null** if *deviceTypes* was passed as [CoreInputDeviceTypes.None](/uwp/api/windows.ui.core.coreinputdevicetypes) (that's not a typical way to call CreateCoreIndependentInputSource though).


<!--Implementation detail? Or is there a scenario for that usage?-->

## -examples

## -see-also
[CoreIndependentInputSource](/uwp/api/windows.ui.core.coreindependentinputsource), [ThreadPool](/uwp/api/windows.system.threading.threadpool), [Threading and async programming](/windows/uwp/threading-async/index), [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)), [XAML SwapChainPanel DirectX interop sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20SwapChainPanel%20DirectX%20interop%20sample), [Low latency input sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620566)
