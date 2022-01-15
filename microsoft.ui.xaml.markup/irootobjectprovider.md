---
-api-id: T:Microsoft.UI.Xaml.Markup.IRootObjectProvider
-api-type: winrt interface
---

# Microsoft.UI.Xaml.Markup.IRootObjectProvider

<!--
public interface IRootObjectProvider
-->

## -description

Describes a service that can return the root object of markup being parsed.

## -remarks

The IRootObjectProvider service is typically only relevant to application services that are exposed by a particular framework or by capabilities of a commonly-used root element class in a framework.

Type converters and markup extensions can query for IRootObjectProvider as a service on the service context that is provided by a XAML object writer, when the XAML object writer invokes value conversion behavior. For more information, see [Type Converters and Markup Extensions for XAML](/dotnet/desktop/xaml-services/type-converters-and-markup-extensions) and [Service Contexts Available to Type Converters and Markup Extensions](/dotnet/desktop/xaml-services/service-contexts-with-type-converters-and-markup-extensions).

## -see-also

## -examples
