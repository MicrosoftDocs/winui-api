---
-api-id: P:Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Handled

## -description
Gets or sets a value that indicates whether the exception is handled.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
**true** to mark the exception as handled, which indicates that the event system should not process it further; otherwise, **false**.

## -remarks
Do not routinely set this value to **true**, that is not always safe and may not guarantee that the app wouldn't terminate anyways. For more info, see [Exception handling for    in C# or Visual Basic](/previous-versions/windows/apps/dn532194(v=win.10)) and Remarks in [UnhandledException](application_unhandledexception.md).

## -examples

## -see-also
[UnhandledException](application_unhandledexception.md), [Exception handling for    in C# or Visual Basic](/previous-versions/windows/apps/dn532194(v=win.10)), [Exceptions (C++/CX)](/cpp/cppcx/exceptions-c-cx)
