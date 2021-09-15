---
-api-id: T:Microsoft.UI.Xaml.Controls.InfoBadge
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.InfoBadge

<!--
public class InfoBadge : Windows.UI.Xaml.Controls.Control
-->


## -description
Represents a control that displays brief status as an icon, number, or dot. 


## -remarks
If neither `InfoBadge.Value` nor `InfoBadge.IconSource` are set to non-default values, the InfoBadge
defaults to showing a dot. If both of these properties are set, the value appears in a numeric 
InfoBadge.  The default value for `Value` is -1, and for `IconSource` is `null`.

In order to hide the InfoBadge, the `InfoBadge.Opacity` property needs to be set to `0`. 

## -see-also

[InfoBadge overview](/windows/apps/design/controls/info-badge)

## -examples
Here's an example of a simple InfoBadge that's set to display the number of unread emails:

```xml
<InfoBadge x:Name="emailInfoBadge" Value="{x:Bind numUnreadMail}"/>
```



