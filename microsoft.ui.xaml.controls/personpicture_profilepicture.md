---
-api-id: P:Microsoft.UI.Xaml.Controls.PersonPicture.ProfilePicture
-api-type: winrt property

---
<!-- Property syntax.
public ImageSource ProfilePicture { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.PersonPicture.ProfilePicture



## -description

Gets or sets the source of the contact's profile picture.



## -property-value

An object that represents the image source file for the drawn image. Typically you set this with a [BitmapImage](/uwp/api/windows.ui.xaml.media.imaging.bitmapimage) object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a [BitmapSource](/uwp/api/windows.ui.xaml.media.imaging.bitmapsource) with a stream, perhaps a stream from a storage file.



## -remarks



## -see-also



## -examples



## -xaml-syntax

```xaml
<PersonPicture ProfilePicture="uri"/>
```



## -xaml-values

<dl><dt>uri</dt><dd>uriThe location of the image source file. In XAML syntax, you can specify what appears to be a relative that is relative to a base . The base is interpreted based on the location of the XAML file that loads it, and uses the ms-appx: scheme implicitly. For more info see Image.Source.</dd>
</dl>



