Responsive images sample widget
===========================================

>**Latest supported version**: Sitefinity CMS 11.0.6700.0

>**Documentation articles**: [Tutorial: Create a custom widget to display responsive images](http://docs.sitefinity.com/tutorial-create-a-custom-widget-to-display-responsive-images)

### Overview

This sample demonstrates how to build a custom widget that displays responsive images. You can download the source code and implement it. Alternatively, you can follow the steps in the documentation article to create the widget from scratch. 

Responsive design technique builds a single template that dynamically adapts to any resolution or a device.

### Prerequisites
- You must have a Sitefinity CMS license.
- Your setup must comply with the system requirements.  
 For more information, see the [System requirements](https://docs.sitefinity.com/system-requirements) for the  respective Sitefinity CMS version.

### Installation

1. Clone the sample repository.
2. Clear the NuGet cache files.  
 a. Open the solution file in Visual Studio.  
 b. In the toolbar, navigate to _Tools >> NuGet Package Manager >> Package Manager Settings_.  
 c. In the left pane, navigate to _NuGet Package Manager >> General_.  
 d. Click _Clear All NuGet Cache(s)_.  
3. Restore the NuGet packages in the solution.  
   
   >**NOTE**: The solution in this repository relies on NuGet packages with automatic package restore while the build procedure takes place.   
   >For a full list of the referenced packages and their versions see the [packages.config](http://github.com/Sitefinity/Telerik.Sitefinity.Samples.ResponsiveImages/blob/master/packages.config) file.    
   >For a history and additional information related to package versions on different releases of this repository, see the [Releases page](http://github.com/Sitefinity/Telerik.Sitefinity.Samples.ResponsiveImages/releases).
   >  
   a. Navigate to _Tools >> NuGet Package Manager >> Package Manager Console_.  
   b. In _Source_, select Sitefinity CMS NuGet Repository.  
   c. Click _Restore_ button.
4. Add a reference to the `ResponsiveImages.dll` file in your SitefinityWebApp
5. Build the solution and restart the application.

### Run the sample

1. Perform procedure [Registering a new widget in Sitefinity CMS](http://docs.sitefinity.com/register-a-new-widget-in-sitefinity-toolbox).   
 Register the widget with the following properties:    
   - _Control CLR Type or Virtual Path_:  `ResponsiveImages.ResponsiveImage`   
   - _Name_: `ResponsiveImage`  
   - _Title_: `ResponsiveImage`  
2. Run the project and click _Content_ >> _Images_.
3. Upload some images.
4. On _Images_ page, in the right pane, click _Thumbnails settings_.
5. Click _Add an image thumbnail size_ button and create three thumbnail sizes with the following properties:


| **Property**                          | Thumbnail size 1                            | Thumbnail size 2                             | Thumbnail size 3                            |
|-----------------------------------|---------------------------------------------|----------------------------------------------|---------------------------------------------|
| **Name**                              | Big screen phones                           | Tablets                                      | Big tablets                                 |
| **Resize image**                      | Resize to area                              | Resize to area                               | Resize to area                              |
| **Max width**                         | 480                                         | 600                                          | 768                                         |
| **Max height**                        | 480                                         | 600                                          | 768                                         |
| **Quality**                           | High                                        | High                                         | High                                        |
| **For developers: name used in code** | thumb480                                    | thumb600                                     | thumb768                                    |
| The thumbnail will be valid for:       | Devices with width 480px to 960px | Devices with width 600px to 1024px | Devices with width 480px to 960px |
6. Drag the _ResponsiveImage_ widget on the page and click its _Edit_ button.
7. Click _Change photo_ and select one of the uploaded images.
8. Click _Save_ and view the page on the frontend.  
 You are now able to view the image resized according to your screen size.

### Additional resources
Youtube video demo:   
[![Responsive/adaptive images in Sitefinity CMS](https://raw.githubusercontent.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.ResponsiveImages/master/VideoEmbed.png)](https://www.youtube.com/watch?v=mUEJJx1S8Ak)
