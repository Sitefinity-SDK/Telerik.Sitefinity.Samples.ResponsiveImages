Progress.Sitefinity.Samples.ResponsiveImages
===========================================

### Latest supported version: Sitefinity CMS 11.0.6700.0

## Responsive Images Sample

Responsive design technique builds a single template that dynamically adapts to any resolution or a device. For more information, see [Displaying pages on mobile devices] (http://www.sitefinity.com/documentation/documentationarticles/download-and-install-the-responsiveimage-widget). In the Sitefinity CMS responsive design module, responsive images do not come out-of-the-box. This article demonstrates how to build a custom widget that displays responsive images.You can download the source code and implement it. Alternatively, you can follow the steps below to create the widget from scratch. 

### Requirements
You must have a Sitefinity CMS license
For more information, see the [System requirements](https://docs.sitefinity.com/system-requirements) for the  respective Sitefinity CMS version.

### Prerequisites

Clear the NuGet cache files. To do this:

1. In Windows Explorer, open the **%localappdata%\NuGet\Cache** folder.
2. Select all files and delete them.

### Nuget package restoration
The solution in this repository relies on NuGet packages with automatic package restore while the build procedure takes place.   
For a full list of the referenced packages and their versions see the [packages.config](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.ResponsiveImages/blob/master/packages.config) file.    
For a history and additional information related to package versions on different releases of this repository, see the [Releases page](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.ResponsiveImages/releases).    

### Installation instructions: SDK Samples from GitHub

1. Clone the sample repository
2. Open the .sln file in Visual Studio
2. Build the sample solution
3. Add a reference to the ResponsiveImages.dll file in your SitefinityWebApp
4. Build the solution and restart the application

### Run the sample

1. Perform procedure [Registering a new widget in Sitefinity CMS](http://docs.sitefinity.com/register-a-new-widget-in-sitefinity-toolbox).   
Register the widget with the following properties:    
**Control CLR Type or Virtual Path**:  ResponsiveImages.ResponsiveImage   
**Name**: ResponsiveImage  
**Title**:  ResponsiveImage
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
Youtube video demo:   
[![Responsive/adaptive images in Sitefinity CMS](https://raw.githubusercontent.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.ResponsiveImages/master/VideoEmbed.png)](https://www.youtube.com/watch?v=mUEJJx1S8Ak)

[Create a custom widget to display responsive images](http://docs.sitefinity.com/tutorial-create-a-custom-widget-to-display-responsive-images)
