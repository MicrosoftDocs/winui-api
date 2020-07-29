---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.RemoveEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.RemoveEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)

<!--
public void RemoveEventHandler (object xamlDirectObject, Microsoft.UI.Xaml.Core.Direct.XamlEventIndex eventIndex, object handler);
-->

## -description

Removes the specified event handler from this [IXamlDirect](ixamldirect.md). 

## -parameters

### -param xamlDirectObject

A reference to the current [IXamlDirect](ixamldirect.md).

### -param eventIndex

An identifier for the event to remove the handle for specified through [XamlEventIndex](xamleventindex.md) enum.

### -param handler

A reference to the specified handler implementation.

## -remarks

Typically, the specified handler was added by [IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object,System.Boolean)](ixamldirect_addeventhandler_1505961231.md).

RemoveEventHandler can only be used to remove event handlers for the events supported by the [XamlEventIndex](xamleventindex.md) enumeration. 

Calling this method has no effect if there were no handlers registered with criteria that match the input parameters for the method call.

This method ignores whether _handledEventsToo_ parameter was true in the [IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object,System.Boolean)](ixamldirect_addeventhandler_1505961231.md) call that originally attached the handler.

## -see-also

[IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)](ixamldirect_addeventhandler_800589073.md), [IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object,System.Boolean)](ixamldirect_addeventhandler_1505961231.md), [UIElement.AddHandler](/uwp/api/windows.ui.xaml.uielement.addhandler), [UIElement.RemoveHandler](/uwp/api/windows.ui.xaml.uielement.removehandler)

## -examples

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirect toggleSwitch = xd.CreateInstance(XamlTypeIndex.ToggleSwitch);

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

IXamlDirect^ toggleSwitch = xd->CreateInstance(XamlTypeIndex::ToggleSwitch);

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
