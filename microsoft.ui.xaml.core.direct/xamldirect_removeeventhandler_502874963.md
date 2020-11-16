---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.RemoveEventHandler(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlDirect.RemoveEventHandler(IXamlDirectObject xamlDirectObject, XamlEventIndex eventIndex, Object handler)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.RemoveEventHandler

## -description
Removes the specified event handler from this [IXamlDirectObject](ixamldirectobject.md). Typically, the handler in question was added by [XamlDirect.AddEventHandler](xamldirect_addeventhandler_737632390.md).

## -parameters
### -param xamlDirectObject
A reference to the current [IXamlDirectObject](ixamldirectobject.md).

### -param eventIndex
An identifier for the event to remove the handle for specified through [XamlEventIndex](xamleventindex.md) enum.

### -param handler
A reference to the specified handler implementation.

## -remarks
RemoveEventHandler can only be used to remove event handlers for the events supported by the [XamlEventIndex](xamleventindex.md) enumeration. 

Calling this method has no effect if there were no handlers registered with criteria that match the input parameters for the method call.

This method ignores whether _handledEventsToo_ parameter was true in the [XamlDirect.AddEventHandler](xamldirect_addeventhandler_737632390.md) call that originally attached the handler.

## -see-also

[XamlDirect.AddEventHandler](xamldirect_addeventhandler_1569472666.md), [XamlDirect.AddEventHandler](xamldirect_addeventhandler_737632390.md), [UIElement.AddHandler](/uwp/api/windows.ui.xaml.uielement.addhandler(windows.ui.xaml.routedevent,system.object,system.boolean)), [UIElement.RemoveHandler](/uwp/api/windows.ui.xaml.uielement.removehandler(windows.ui.xaml.routedevent,system.object))

## -examples

The following example shows how to add/modify and remove the [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) event through a specific instance of [PointerEventHandler](../microsoft.ui.xaml.input/pointereventhandler.md) on a [ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md) control from its [IXamlDirectObject](ixamldirectobject.md) instance.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject toggleSwitch = xd.CreateInstance(XamlTypeIndex.ToggleSwitch);

PointerEventHandler toggleSwitchPointerHandler = new PointerEventHandler((sender, args) =>
{
    if (sender is ToggleSwitch)
    {
        ((ToggleSwitch)sender).IsOn = !((ToggleSwitch)sender).IsOn;
    }
});

xd.AddEventHandler(toggleSwitch, XamlEventIndex.UIElement_PointerEntered, toggleSwitchPointerHandler);
xd.RemoveEventHandler(toggleSwitch, XamlEventIndex.UIElement_PointerEntered, toggleSwitchPointerHandler);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ toggleSwitch = xd->CreateInstance(XamlTypeIndex::ToggleSwitch);

PointerEventHandler^ toggleSwitchPointerHandler = ref new PointerEventHandler([&](Platform::Object^ sender, PointerRoutedEventArgs^ args)
{
    ToggleSwitch^ ts = dynamic_cast<ToggleSwitch^>(sender);
    if (nullptr != ts)
    {
        ts->IsOn = !ts->IsOn;
    }
});

xd->AddEventHandler(toggleSwitch, XamlEventIndex::UIElement_PointerEntered, toggleSwitchPointerHandler);
xd->RemoveEventHandler(toggleSwitch, XamlEventIndex::UIElement_PointerEntered, toggleSwitchPointerHandler);
```
