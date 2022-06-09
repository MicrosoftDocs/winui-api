---
-api-id: T:Microsoft.UI.Xaml.DependencyObject
-api-type: winrt class
---

<!-- Class syntax.
public class DependencyObject : Windows.UI.Xaml.IDependencyObject, Windows.UI.Xaml.IDependencyObject2
-->

# Microsoft.UI.Xaml.DependencyObject

## -description
Represents an object that participates in the dependency property system. DependencyObject is the immediate base class of many important UI-related classes, such as [UIElement](uielement.md), [Geometry](../microsoft.ui.xaml.media/geometry.md), [FrameworkTemplate](frameworktemplate.md), [Style](style.md), and [ResourceDictionary](resourcedictionary.md). For more info on how DependencyObject supports dependency properties, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The DependencyObject class enables dependency property system services on its many derived classes. For more info about the dependency property concept, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

The dependency property system's primary function is to compute the values of properties, and to provide system notification about values that have changed. Another key class that participates in the dependency property system is [DependencyProperty](dependencyproperty.md). [DependencyProperty](dependencyproperty.md) enables the registration of dependency properties into the property system, whereas DependencyObject as a base class enables objects to use and set the dependency properties.

Here are some notable services and characteristics that DependencyObject provides or supports:


+ Dependency property hosting support for the existing Windows Runtime dependency properties.
+ Custom dependency property hosting support. You register a dependency property by calling the [Register](dependencyproperty_register_928563513.md) method and storing the method's return value as a public static property in your DependencyObject class.
+ Attached property hosting support for the existing Windows Runtime attached properties.
+ Custom attached property hosting support. You register a dependency property for the attached property usage by calling the [RegisterAttached](dependencyproperty_registerattached_518296660.md) method and storing the method's return value as a public static property in your class.
+ **Get** and **Set** utility methods for values of any dependency properties that exist on a DependencyObject. You use these when defining custom dependency property "wrappers" and can also use them from app code as an alternative to using existing "wrapper" properties.
+ Advanced-scenario utility for examining metadata or property values (for example [GetAnimationBaseValue](dependencyobject_getanimationbasevalue_1955567622.md)).
+ Enforcement of thread affinity to the main UI thread of the Windows Runtime for all DependencyObject instances.
+ The [Dispatcher](dependencyobject_dispatcher.md) property for advanced threading scenarios. Getting the [Dispatcher](dependencyobject_dispatcher.md) value provides a reference to a [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) object. With the [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher), a worker thread can run code that use a DependencyObject but is not on the UI thread, because the [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) can defer the execution to an asynchronous operation that won't block or otherwise interfere with the UI thread. See "**DependencyObject** and threading" section below.
+ Basic data binding and styling support, by enabling properties to be set as expressions to be evaluated at some later point in an object's lifetime. These concepts are explained in more detail in [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview). See also [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).


### **DependencyObject** and threading

All DependencyObject instances must be created on the UI thread that is associated with the current [Window](window.md) for an app. This is enforced by the system, and there are two important implications of this for your code:
+ Code that uses API from two DependencyObject instances will always be run on the same thread, which is always the UI thread. You don't typically run into threading issues in this scenario.
+ Code that is not running on the main UI thread cannot access a DependencyObject directly because a DependencyObject has thread affinity to the UI thread only. Only code that runs on the UI thread can change or even read the value of a dependency property. For example a worker thread that you've initiated with a .NET **Task** or an explicit [ThreadPool](/uwp/api/windows.system.threading.threadpool) thread won't be able to read dependency properties or call other APIs.


You aren't completely blocked from using a DependencyObject from a worker thread. But you must get a [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) object (the value of [DependencyObject.Dispatcher](dependencyobject_dispatcher.md)) from a DependencyObject in order to get across the deliberate separation between the app UI thread and any other threads running on the system. The [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) exposes the [RunAsync](/uwp/api/windows.ui.core.coredispatcher.runasync(windows.ui.core.coredispatcherpriority,windows.ui.core.dispatchedhandler)) method. Call [RunAsync](/uwp/api/windows.ui.core.coredispatcher.runasync(windows.ui.core.coredispatcherpriority,windows.ui.core.dispatchedhandler)) to run your awaitable code (an [IAsyncAction](/uwp/api/windows.foundation.iasyncaction)). If it's simple code you can use a lambda expression, otherwise you can implement as a delegate ([DispatchedHandler](/uwp/api/windows.ui.core.dispatchedhandler)). The system determines a time that your code can be run. Because it's enabling access across threads, [DependencyObject.Dispatcher](dependencyobject_dispatcher.md) is the only instance API of DependencyObject or any of its subclasses that can be accessed from a non-UI thread without throwing a cross-thread exception. All other DependencyObject APIs throw an exception if you attempt to call them from a worker thread or any other non-UI thread.

Threading issues can usually be avoided in typical UI code. However, devices aren't usually associated with the UI thread. If you are using info obtained from a device to update the UI in real-time, you often must get a [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) so that you can update the UI. Services are another case where the code you use to access the service might not be running on the UI thread.

One code scenario where you might encounter DependencyObject-related threading issues if you are defining your own DependencyObject types and you attempt to use them for data sources, or other scenarios where a DependencyObject isn't necessarily appropriate (because the object is not directly related to the UI). For example, you might be attempting perf optimizations with background threads or other worker threads that are changing values of the objects prior to presentation, or in response to a device, service or other external input. Evaluate whether you really need dependency properties for your scenario; maybe standard properties are adequate.

### **DependencyObject** derived classes

DependencyObject is the parent class for several immediately derived classes that are all fundamental to the programming model you use for your app and its XAML UI. Here are some of the notable derived classes:

+ [UIElement](uielement.md): The base class for most visual objects that can process input in the UI. [FrameworkElement](frameworkelement.md) is further in this hierarchy, as is [Control](../microsoft.ui.xaml.controls/control.md), so there are hundreds of controls and other classes in the Windows Runtime that all have the [UIElement](uielement.md) class in their class hierarchies.
+ XAML style system support classes: [FrameworkTemplate](frameworktemplate.md) (parent of [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md), [DataTemplate](datatemplate.md), [ItemsPanelTemplate](../microsoft.ui.xaml.controls/itemspaneltemplate.md)), [Style](style.md), [SetterBase](setterbase.md) (parent of [Setter](setter.md)), [ToolTipTemplateSettings](../microsoft.ui.xaml.controls.primitives/tooltiptemplatesettings.md) and other ***TemplateSettings**.
+ Visual state model: [Transition](../microsoft.ui.xaml.media.animation/transition.md), [VisualState](visualstate.md), [VisualStateGroup](visualstategroup.md), [VisualStateManager](visualstatemanager.md), [VisualTransition](visualtransition.md).
+ Data binding support: [BindingBase](../microsoft.ui.xaml.data/bindingbase.md) (parent of [Binding](../microsoft.ui.xaml.data/binding.md)), [CollectionViewSource](../microsoft.ui.xaml.data/collectionviewsource.md), [PropertyPath](propertypath.md), [RelativeSource](../microsoft.ui.xaml.data/relativesource.md).
+ Storyboarded animations: [Timeline](../microsoft.ui.xaml.media.animation/timeline.md) (parent of [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md), typed animations, theme animations), typed keyframes (like [ColorKeyFrame](../microsoft.ui.xaml.media.animation/colorkeyframe.md)), [KeySpline](../microsoft.ui.xaml.media.animation/keyspline.md), [EasingFunctionBase](../microsoft.ui.xaml.media.animation/easingfunctionbase.md).
+ XAML graphics and rendering primitives: [Brush](../microsoft.ui.xaml.media/brush.md), [Geometry](../microsoft.ui.xaml.media/geometry.md), [GeneralTransform](../microsoft.ui.xaml.media/generaltransform.md), [GradientStop](../microsoft.ui.xaml.media/gradientstop.md), [PathFigure](../microsoft.ui.xaml.media/pathfigure.md), [PathSegment](../microsoft.ui.xaml.media/pathsegment.md), [Projection](../microsoft.ui.xaml.media/projection.md).
+ Imaging and render surface interop: [ImageSource](../microsoft.ui.xaml.media/imagesource.md) (parent of [BitmapSource](../microsoft.ui.xaml.media.imaging/bitmapsource.md), [RenderTargetBitmap](../microsoft.ui.xaml.media.imaging/rendertargetbitmap.md), [SurfaceImageSource](../microsoft.ui.xaml.media.imaging/surfaceimagesource.md) and others).
+ [Window](window.md): represents the main app window.
+ [FlyoutBase](../microsoft.ui.xaml.controls.primitives/flyoutbase.md) (parent of [Flyout](../microsoft.ui.xaml.controls/flyout.md) and [MenuFlyout](../microsoft.ui.xaml.controls/menuflyout.md)).
+ [ResourceDictionary](resourcedictionary.md): defines keyed resources in XAML.
+ [TextElement](../microsoft.ui.xaml.documents/textelement.md): parent of [Block](../microsoft.ui.xaml.documents/block.md) and [Inline](../microsoft.ui.xaml.documents/inline.md), these in turn are base classes for text elements used for [TextBlock](../microsoft.ui.xaml.controls/textblock.md) content or the rich text elements.
+ [AutomationPeer](../microsoft.ui.xaml.automation.peers/automationpeer.md): base class for Microsoft UI Automation peers that represent XAML controls to a Microsoft UI Automation listener. Also, [IRawElementProviderSimple](../microsoft.ui.xaml.automation.provider/irawelementprovidersimple.md).
+ Miscellaneous: [CacheMode](uielement_cachemode.md), [ColumnDefinition](../microsoft.ui.xaml.controls/columndefinition.md), [DependencyObjectCollection](dependencyobjectcollection.md), [InputScope](../microsoft.ui.xaml.input/inputscope.md), [InputScopeName](../microsoft.ui.xaml.input/inputscopename.md), [PageStackEntry](../microsoft.ui.xaml.navigation/pagestackentry.md), [PrintDocument](../microsoft.ui.xaml.printing/printdocument.md), [RowDefinition](../microsoft.ui.xaml.controls/rowdefinition.md), [TimelineMarker](../microsoft.ui.xaml.media/timelinemarker.md), [TriggerAction](triggeraction.md), [TriggerBase](triggerbase.md).


## -examples
This example defines a class that derives from DependencyObject, and defines an attached property along with the identifier field. The scenario for this class is that it is a service class that declares an attached property that other UI elements can set in XAML The service potentially acts on the attached property values on those UI elements at run time.



[!code-csharp[DOMain](../microsoft.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOMain)]

[!code-vb[DOMain](../microsoft.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOMain)]

[!code-csharp[DOCheckClear](../microsoft.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOCheckClear)]

[!code-vb[DOCheckClear](../microsoft.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOCheckClear)]

This example shows a simple dependency property declaration. A call to [GetValue](dependencyobject_getvalue_229640130.md) constitutes the entirety of the **get** accessor implementation for the property wrapper of the new dependency property. A call to [SetValue](dependencyobject_setvalue_1212521140.md) constitutes the entirety of the **set** accessor implementation. For more examples, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).



[!code-csharp[DOSimpleDP](../microsoft.ui.xaml/code/DOandDP/csharp/Class1.cs#DOSimpleDP)]

[!code-vb[DOSimpleDP](../microsoft.ui.xaml/code/DOandDP/vbnet/Class1.vb#DOSimpleDP)]

## -see-also
[DependencyProperty](dependencyproperty.md), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Custom attached properties](/windows/uwp/xaml-platform/custom-attached-properties), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
