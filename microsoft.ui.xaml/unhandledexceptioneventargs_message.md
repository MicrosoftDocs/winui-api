---
-api-id: P:Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Message
-api-type: winrt property
---

<!-- Property syntax
public string Message { get; }
-->

# Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Message

## -description
Gets the message string as passed by the originating unhandled exception.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The message string, which may be useful for debugging.

## -remarks
The message is coming from info that's propagated by the original system or runtime app error. The message is not guaranteed to be an exact match to the original error message (as seen in native stacks or output windows). For more info on error propagation and exception handling techniques, see [Exception handling for    in C# or Visual Basic](/previous-versions/windows/apps/dn532194(v=win.10)) and Remarks in [UnhandledException](application_unhandledexception.md).

## -examples

## -see-also
[UnhandledException](application_unhandledexception.md), [Exception handling for    in C# or Visual Basic](/previous-versions/windows/apps/dn532194(v=win.10)), [Exceptions (C++/CX)](/cpp/cppcx/exceptions-c-cx)
