---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.ButtonBase.Command
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Input.ICommand Command { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.ButtonBase.Command

## -description
Gets or sets the command to invoke when this button is pressed.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<button Command="commandReference"/>

```


## -xaml-values
<dl><dt>commandReference</dt><dd>commandReferenceA reference to an ICommand implementation that describes the command logic. Typically this is done through a {Binding} markup extension reference to a data source, when using view-view model designs.</dd>
</dl>
## -property-value
The command to invoke when this button is pressed. The default is null.

## -remarks
The **ICommand** interface comes from a different source depending on whether the data source is implemented in C++ or for Microsoft .NET. C++ implements [Windows::UI::Xaml::Input::ICommand](../microsoft.ui.xaml.input/icommand.md). Microsoft .NET implements [System.Windows.Input.ICommand](/dotnet/api/system.windows.input.icommand?view=dotnet-uwp-10.0&preserve-view=true). Both interfaces have the same template. Which interface you call from your app code is analogous: use [Windows::UI::Xaml::Input::ICommand](../microsoft.ui.xaml.input/icommand.md) for C++ code and [System.Windows.Input.ICommand](/dotnet/api/system.windows.input.icommand?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET code.

## -examples

## -see-also
