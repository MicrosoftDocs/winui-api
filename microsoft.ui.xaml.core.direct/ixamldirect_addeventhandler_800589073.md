---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Core.Direct.IXamlDirect.AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)

<!--
public void AddEventHandler (object xamlDirectObject, Microsoft.UI.Xaml.Core.Direct.XamlEventIndex eventIndex, object handler);
-->

## -description

Adds the specified event handler for a specified event using [XamlEventIndex](xamleventindex.md), adding the handler to the handler collection on the specified object.

## -parameters

### -param xamlDirectObject

A reference to the object receiving the event handler.

### -param eventIndex

An identifier for the event to be handled specified through [XamlEventIndex](xamleventindex.md) enum.

### -param handler

A reference to the specified handler implementation.

## -remarks

AddEventHandler can only be used to add event handlers for the events supported by the [XamlEventIndex](xamleventindex.md) enumeration. You can use this method to add handlers to routed as well non-routed events supported by the xaml object.

## -see-also

[AddEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object,System.Boolean)](ixamldirect_addeventhandler_1505961231.md), [RemoveEventHandler(System.Object,Microsoft.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)](ixamldirect_removeeventhandler_1875707612.md)

## -examples

The following example shows how to add/modify the [PointerEntered](/uwp/api/windows.ui.xaml.uielement.pointerentered) event through a specific instance of [PointerEventHandler](/uwp/api/windows.ui.xaml.input.pointereventhandler) on a [ToggleSwitch](/uwp/api/windows.ui.xaml.controls.toggleswitch) control from its [IXamlDirect](ixamldirect.md) instance.

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
```
