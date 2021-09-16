---
-api-id: T:Microsoft.UI.Xaml.Controls.InfoBadge
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.InfoBadge

<!--
public class InfoBadge : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control for indicating notifications, alerts, new content, or to attract focus to an area within an app.

## -remarks

If neither [InfoBadge.Value](infobadge_value.md) and [InfoBadge.IconSource](infobadge_iconsource.md) InfoBadge.IconSource are set (default values are used), the InfoBadge defaults to a dot indicator. If both Value and IconSource properties are set, the Value property is used.

To hide the InfoBadge, set its [Opacity](../microsoft.ui.xaml/uielement_opacity.md) property to 0.

## -see-also

[InfoBadge overview](/windows/apps/design/controls/info-badge)

## -examples

Here's an example of a simple InfoBadge that's set to display the number of unread emails:

```xml
<InfoBadge x:Name="emailInfoBadge" Value="{x:Bind numUnreadMail}"/>
```
