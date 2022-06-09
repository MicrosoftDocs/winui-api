---
-api-id: P:Microsoft.UI.Xaml.Controls.Button.Flyout
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Primitives.FlyoutBase Flyout { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Button.Flyout

## -description
Gets or sets the flyout associated with this button.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Button>
  <Button.Flyout>flyout</Button.Flyout>
</Button>
- or -
<Button Flyout="{StaticResurce flyoutResourceKey"/>

```


## -xaml-values
<dl><dt>flyout</dt><dd>flyoutAn instance of a FlyoutBase derived class; typically Flyout or MenuFlyout.</dd>
<dt>flyoutResourceKey</dt><dd>flyoutResourceKeyThe key that identifies the flyout being requested. The key refers to an existing resource in a ResourceDictionary.</dd>
</dl>
## -property-value
The flyout associated with this button, if any; otherwise, **null**. The default is **null**.

## -remarks
By default, the flyout that's set as the value of the Flyout property displays when the button is tapped or otherwise invoked, you don't need to call methods to display it. That differs from the behavior of flyouts assigned through the [FlyoutBase.AttachedFlyout](/windows/winui/api/microsoft.ui.xaml.controls.primitives.flyoutbase#xaml-attached-properties) attached property; these flyouts must be explicitly displayed by calling [ShowAt](/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.showat(windows.ui.xaml.frameworkelement)) on the flyout instance, or the static [ShowAttachedFlyout](/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.showattachedflyout(windows.ui.xaml.frameworkelement)) method.

## -examples

## -see-also
[Flyout](flyout.md), [MenuFlyout](menuflyout.md), [Quickstart: Adding a Flyout](/previous-versions/windows/apps/dn308515(v=win.10)), [XAML Flyout and MenuFlyout sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20Flyout%20and%20MenuFlyout%20sample)
