---
-api-id: T:Microsoft.UI.Xaml.Controls.ItemsRepeaterScrollHost
-api-type: winrt class
---

## -description

A helper to coordinate interaction between the [ItemsRepeater](itemsrepeater.md) and [ScrollViewer](/uwp/api/windows.ui.xaml.controls.scrollviewer).
Use the ItemsRepeaterScrollHost if your app will run on versions of Windows prior Windows 10 1809 (Build 17763).  If your app will only run on versions of Windows 1809 or higher, there is no need to use this control.

## -remarks

ItemsRepeaterScrollHost is a helper class that you can use to wrap a [ScrollViewer](/uwp/api/windows.ui.xaml.controls.scrollviewer) and provide functionality of new APIs on earlier versions of Windows 10.

Starting in Windows 10, version 1809 (SDK 17763), [ScrollViewer](/uwp/api/windows.ui.xaml.controls.scrollviewer) has properties that coordinate interaction between an ItemsRepeater and the [ScrollViewer](/uwp/api/windows.ui.xaml.controls.scrollviewer). If your app targets versions of Windows 10 prior to version 1809 (SDK 17763), wrap your [ScrollViewer](/uwp/api/windows.ui.xaml.controls.scrollviewer) in an ItemsRepeaterScrollHost to provide the functionality of these APIs.  The properties on ItemsRepeaterScrollHost replicate the same functionality and behavior as the like-named ones found on on [ScrollViewer](/uwp/api/windows.ui.xaml.controls.scrollviewer).

If the minimum target version of your app is Windows 10, version 1809 (SDK 17763) or later, there is no need to use this control.

## -see-also

## -examples

This example shows a scrollable list of people.
```xaml
<Page
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:muxc="using:Microsoft.UI.Xaml.Controls">

    <muxc:ItemsRepeaterScrollHost>
        <ScrollViewer>
            <muxc:ItemsRepeater ItemsSource='{x:Bind PeopleCollection}' />
        </ScrollViewer>
    </muxc:ItemsRepeaterScrollHost> 
    
</Page
```

