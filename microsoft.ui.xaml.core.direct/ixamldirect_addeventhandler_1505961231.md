---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object,System.Boolean)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object,System.Boolean)

<!--
public void AddEventHandler (object xamlDirectObject, Microsoft.UI.Xaml.Core.Direct.XamlEventIndex eventIndex, object handler, bool handledEventsToo);
-->

## -description

Adds the specified event handler for a specified event using [XamlEventIndex](xamleventindex.md), adding the handler to the handler collection on the current [IXamlDirect](ixamldirect.md). Specify *handledEventsToo* as true to have the provided handler be invoked even if the event is handled elsewhere.

## -parameters

### -param xamlDirectObject

A reference to the current [IXamlDirect](ixamldirect.md).

### -param eventIndex

An identifier for the event to be handled specified through [XamlEventIndex](xamleventindex.md) enum.

### -param handler

A reference to the specified handler implementation.

### -param handledEventsToo

**true** to register the handler such that it is invoked even when the routed event is marked handled in its event data.

**false** to register the handler with the default condition that it will not be invoked if the routed event is already marked handled. 

The default is false and the parameter is optional.

## -remarks

AddEventHandler can only be used to add event handlers for the events supported by the [XamlEventIndex](xamleventindex.md) enumeration. You can use this method to add handlers to routed as well non-routed events supported by the xaml object.

See [UIElement.AddHandler](/uwp/api/windows.ui.xaml.uielement.addhandler) for when to use _handledEventsToo_ and the restrictions around the same. For non-routed events, the _handleEventsToo_ flag is completely ignored.

## -see-also

[Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)](ixamldirect_addeventhandler_800589073.md), [Microsoft.UI.Xaml.Core.Direct.IXamlDirect.RemoveEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)](ixamldirect_removeeventhandler_1875707612.md), [UIElement.AddHandler](/uwp/api/windows.ui.xaml.uielement.addhandler), [UIElement.RemoveHandler](/uwp/api/windows.ui.xaml.uielement.removehandler)

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

xd.AddEventHandler(toggleSwitch, XamlEventIndex.UIElement_PointerEntered, toggleSwitchPointerHandler, true);
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

xd->AddEventHandler(toggleSwitch, XamlEventIndex::UIElement_PointerEntered, toggleSwitchPointerHandler, true);
```
