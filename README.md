# About Action Toast

**Action Toast** is simple, quick, single line popup notification system for iOS in the style of **Toast** for Android. **Action Toast** implements the same calling structure and styles as **Toast** for Android to assist in cross platform development.

# Running the Samples

Before you can successfully build and run these sample apps, you'll need to download and install the [Action Components Trail](http://appracatappra.com/products/action-components/) version from the Appracatappra website or have purchased and installed a licensed version of the components.

Next, open the iOS version of the sample in Visual Studio and expand the **Resources** folder:

![](Images/Intro01.png)

If the `ActionComponents` entry is grayed-out with a red X (as shown in the image above), right-click on it and select **Delete**. Double-Click the **Resources** folder to open the **Edit References** dialog and select the **.Net Assembly** tab:

![](Images/Intro02.png)

Click the **Browse** button, navigate to where you installed the **Action Components** trial or licensed version and locate the appropriate `ActionComponents.ddl` (for either iOS or Android) and click the **OK** button. The sample will now be ready to run.

# Easy Implementation

Need to quickly catch a user’s attention with a single line notification? **Action Toast** makes it easy. Either create an object of type `ACToast` and fill out it’s properties or use the static `MakeText` method of the Action Toast class to create a popup. Next call the `Show` method to display it, just like in Xamarin.Android.

# Multiple Locations

Action Toast can be set to display in multiple locations by setting the gravity property:

* **Top**
* **Center**
* **Bottom**
* **Custom** – A user defined location

All locations take the device’s screen rotation into account so they always display correctly.

# Multiple Display Lengths

**Action Toast** can be set to display for a given amount of time by either providing the number of seconds to display or by using a `ACToastLength` as:

* **Forever** – the message will display until the user taps it or it is closed programmatically.
* **Short** – display for one second.
* **Medium** – display for two seconds.
* **Long** – display for five seconds.

# Features

**Action Toast** includes a fully documented API with comments for every feature. **Action Toast** is available exclusively as part of the Action Component Suite by Appracatappra, LLC.

# iOS Example

Here is an example of quickly displaying an **Action Toast** message:

```csharp
using ActionComponents;
...

// Display message to user
ACToast.MakeText("My message", ACToastLength.Long).Show ();
```

Additionally, you can use one of the `ShowText` shortcut methods:

```csharp
using ActionComponents;
...

// Display message to user
ACToast.ShowText("Message at Center.", ACToastGravity.Center);
```

# Trial Version

The Trial version of **Action Toast** is fully functional however the background is watermarked. The fully licensed version removes this watermark.