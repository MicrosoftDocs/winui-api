---
-api-id: M:Microsoft.UI.Xaml.Controls.GroupStyleSelector.SelectGroupStyleCore(System.Object,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Controls.GroupStyle SelectGroupStyleCore(System.Object group, System.UInt32 level)
-->

# Microsoft.UI.Xaml.Controls.GroupStyleSelector.SelectGroupStyleCore

## -description
When implemented by a derived class, returns a specific [GroupStyle](groupstyle.md) for a given group and level.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param group
The group to return a [GroupStyle](groupstyle.md) for.

### -param level
The level of nesting for the specified group.

## -returns
The [GroupStyle](groupstyle.md) to use for the specified group and level.

## -remarks
> **Windows 8**
> In Windows 8, you can pass **null** as the *group* parameter value. In Windows 8.1, passing **null** causes an error.

## -examples

## -see-also
[How to group items in a list or grid](/previous-versions/windows/apps/hh780627(v=win.10))
