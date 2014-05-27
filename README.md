Telerik.Sitefinity.Samples.ResponsiveImages
===========================================

## Responsive Images Sample

Responsive design technique builds a single template that dynamically adapts to any resolution or a device. For more information, see [Displaying pages on mobile devices] (http://www.sitefinity.com/documentation/documentationarticles/download-and-install-the-responsiveimage-widget). In Sitefinity responsive design module, responsive images do not come out-of-the-box. This article demonstrates how to build a custom widget that displays responsive images.You can download the source code and implement it. Alternatively, you can follow the steps below to create the widget from scratch. 

### Requirements

* Sitefinity license

* .NET Framework 4

* Visual Studio 2012

* Microsoft SQL Server 2008R2 or later versions

### Prerequisites

Clear the NuGet cache files. To do this:

1. In Windows Explorer, open the **%localappdata%\NuGet\Cache** folder.
2. Select all files and delete them.


### Installation instructions: SDK Samples from GitHub


1. In Solution Explorer, navigate to _SitefinityWebApp_ -> *App_Data* -> _Sitefinity_ -> _Configuration_ and select the **DataConfig.config** file. 
2. Modify the **connectionString** value to match your server address.
 

### Run the sample

1. Download the ResponsiveImage widget and extract the contents of the ZIP file to a dedicated folder.
2. Open your project in Visual Studio.
3. Copy all the content from the extraction folder.
4. In the context menu of your SitefinityWebApp project, click Paste.
5. Build your solution and restart the application.
   If prompted, save the solution file in the root application folder.
6. Close Visual Studio.
7. Perform procedure Registering a new widget in Sitefinity.
8. Run the project and click Content » Images.
9. Upload some images using procedure Uploading and editing images.
10. On Images page, in the right pane, click Thumbnails settings.
11. Click Add an image thumbnail size button and create three thumbnail sizes with the following properties:


| Property                   | Thumbnail Size 1                           | Thumbnail Size 2                           |
| ---------------------------|:------------------------------------------:|:------------------------------------------:|
| Name                       | Big screen phones                          | Tablets                                    |
| Resize image               | Resize to area                             |   Resize to area                           |
| Max width                  | 480                                        |    600                                     |
| Max height                 | 480                                        |    600                                     |
| Quality                    | High                                       |    High                                    |
| For developers: 
name used in code            | thumb480                                   |    thumb600                                |
| The thumbnail is valid for:| Devices with width 480px to 960px, such as:|    Devices with width 480px to 960px, such as:|
|                            | * HTC - Vivid, Amaze, HD2                  |  *iPad                                     |
|                            | * BlackBerry Bold 9900                     |  *Samsung Galaxy Tab                       |
|                            | * Samsung Galaxy Note 3, etc.              |  * Kindle Fire, etc.                       |

12. Drag the ResponsiveImage widget on the page and click its Edit button.
13. Click Change photo and select one of the uploaded images.
14. Click Save and view the page on the frontend.
You are now able to view the image resized according to your screen size.

### Additional resources

[Create a custom widget to display responsive images](http://www.sitefinity.com/documentation/documentationarticles/create-a-custom-widget-to-display-responsive-images)

