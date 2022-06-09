---
-api-id: M:Microsoft.UI.Xaml.Controls.ContentPresenter.OnContentTemplateSelectorChanged(Microsoft.UI.Xaml.Controls.DataTemplateSelector,Microsoft.UI.Xaml.Controls.DataTemplateSelector)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnContentTemplateSelectorChanged(Windows.UI.Xaml.Controls.DataTemplateSelector oldContentTemplateSelector, Windows.UI.Xaml.Controls.DataTemplateSelector newContentTemplateSelector)
-->

# Microsoft.UI.Xaml.Controls.ContentPresenter.OnContentTemplateSelectorChanged

## -description
Invoked when the value of the [ContentTemplateSelector](contentpresenter_contenttemplateselector.md) property changes.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param oldContentTemplateSelector
The old value of the [ContentTemplateSelector](contentpresenter_contenttemplateselector.md) property.

### -param newContentTemplateSelector
The new value of the [ContentTemplateSelector](contentpresenter_contenttemplateselector.md) property.

## -remarks
Classes that derive from [ContentPresenter](contentpresenter.md) can override this method in order to perform any custom logic that should apply, in cases where the selector logic that automatically chooses the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) based on context changes.

## -examples

## -see-also
