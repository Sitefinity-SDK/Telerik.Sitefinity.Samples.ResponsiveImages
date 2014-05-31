Telerik.Sitefinity.Samples.ResponsiveImages
===========================================

[![Build Status](http://sdk-jenkins-ci.cloudapp.net/buildStatus/icon?job=Telerik.Sitefinity.Samples.ResponsiveImages.CI)](http://sdk-jenkins-ci.cloudapp.net/job/Telerik.Sitefinity.Samples.ResponsiveImages.CI/)

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

1. Clone the sample repository
2. Open the .sln file in Visual Studio
2. Build the sample solution
3. Add a reference to the ResponsiveImages.dll file in your SitefinityWebApp
4. Build the solution and restart the application

### Run the sample

1. Perform procedure [Registering a new widget in Sitefinity] (http://www.sitefinity.com/documentation/documentationarticles/installation-and-administration-guide/system-settings/registering-a-new-widget-in-sitefinity).
2. Run the project and click Content » Images
3. Upload some images using procedure Uploading and editing images.
4. On Images page, in the right pane, click Thumbnails settings.
5. Click Add an image thumbnail size button and create three thumbnail sizes with the following properties:


| Property                          | Thumbnail size 1                            | Thumbnail size 2                             | Thumbnail size 3                            |
|-----------------------------------|---------------------------------------------|----------------------------------------------|---------------------------------------------|
| Name                              | Big screen phones                           | Tablets                                      | Big tablets                                 |
| Resize image                      | Resize to area                              | Resize to area                               | Resize to area                              |
| Max width                         | 480                                         | 600                                          | 768                                         |
| Max height                        | 480                                         | 600                                          | 768                                         |
| Quality                           | High                                        | High                                         | High                                        |
| For developers: name used in code | thumb480                                    | thumb600                                     | thumb768                                    |
| The thumbnail is valid for:       | Devices with width 480px to 960px, such as: | Devices with width 600px to 1024px, such as: | Devices with width 480px to 960px, such as: |
|                                   | HTC - Vivid, Amaze, HD2                     | iPad                                         | Samsung Galaxy Note 8                       |
|                                   | BlackBerry Bold 9900                        | Samsung Galaxy Tab                           | Kindle Fire HD                              |
|                                   | Samsung Galaxy Note 3, etc.                 | Kindle Fire, etc.                            | Samsung Galaxy Tab                          |
|                                   |                                             |                                              | Microsoft Surface Pro, etc.                 |

6. Drag the ResponsiveImage widget on the page and click its Edit button.
7. Click Change photo and select one of the uploaded images.
8. Click Save and view the page on the frontend.
You are now able to view the image resized according to your screen size.

### Additional resources

[![Responsive/adaptive images in Sitefinity](https://raw.githubusercontent.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.ResponsiveImages/master/VideoEmbed.png)](https://www.youtube.com/watch?v=mUEJJx1S8Ak)

[Create a custom widget to display responsive images](http://www.sitefinity.com/documentation/documentationarticles/create-a-custom-widget-to-display-responsive-images)

