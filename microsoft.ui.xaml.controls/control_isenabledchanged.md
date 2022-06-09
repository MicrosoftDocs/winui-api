---
-api-id: E:Microsoft.UI.Xaml.Controls.Control.IsEnabledChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.DependencyPropertyChangedEventHandler IsEnabledChanged
-->

# Microsoft.UI.Xaml.Controls.Control.IsEnabledChanged

## -description
Occurs when the [IsEnabled](control_isenabled.md) property changes.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<control IsEnabledChanged="eventhandler"/>
```


## -remarks
Whenever [IsEnabled](control_isenabled.md) changes, that fires the IsEnabledChanged event. Controls might handle this event in order to change the visual states. The event has [DependencyPropertyChangedEventArgs](../microsoft.ui.xaml/dependencypropertychangedeventargs.md) data, so you can determine the old and new values without having to use your own flags.

A control inherits the [IsEnabled](control_isenabled.md) property from its parent control. For example, if a control that contains a button has [IsEnabled](control_isenabled.md) set to **false**, the button's [IsEnabled](control_isenabled.md) property is also **false**. When the parent's property changes, that fires IsEnabledChanged for each control where the value changes because of the value inheriting.

## -examples

## -see-also
[IsEnabled](control_isenabled.md), [DependencyPropertyChangedEventArgs](../microsoft.ui.xaml/dependencypropertychangedeventargs.md)
