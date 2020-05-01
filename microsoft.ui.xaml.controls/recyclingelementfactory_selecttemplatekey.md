---
-api-id: E:Microsoft.UI.Xaml.Controls.RecyclingElementFactory.SelectTemplateKey
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.RecyclingElementFactory.SelectTemplateKey

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.RecyclingElementFactory,Microsoft.UI.Xaml.Controls.SelectTemplateEventArgs> SelectTemplateKey;
-->

## -description

Occurs when an element is retrieved in order to get a template key for the element.

## -remarks

This event is raised when [GetElement](elementfactory_getelement_845667019.md) is called so that the element factory can determine the template key to use. The template key is then used to lookup a template in the [Templates](recyclingelementfactory_templates.md) dictionary.

## -see-also

## -examples

