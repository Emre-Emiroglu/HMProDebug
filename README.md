<img src="icon.jpg" width="512" height="512" alt="HMProDebug Logo">

# HMProDebug
HMProDebug is a utility package designed to help developers easily apply text formatting and coloring in Unity's debug logs. This package provides a simple and flexible way to enhance the visual readability of debug messages by allowing text to be colored and formatted using both predefined and custom options.

## Features
HMProDebug offers the following capabilities:
* Colorization: Apply predefined or custom colors to text in Unity's debug console.
* Text Formatting: Add bold or italic formatting to text for better emphasis.
* Customization: Supports custom color codes and text formatting styles.
* Editor Integration: A dedicated Unity Editor window for easily managing text colors and formats.

## Getting Started
Install via UPM with git URL

`https://github.com/Emre-Emiroglu/HMProDebug.git`

Clone the repository
```bash
git clone https://github.com/Emre-Emiroglu/HMProDebug.git
```
This project is developed using Unity version 6000.0.42f1.

## Usage
* Colorization: You can apply predefined or custom colors to your debug messages.
    ```csharp
    Debug.Log("Hello World!" % ProDebugUtilities.White);
    Debug.Log("Warning!" % ProDebugUtilities.Red);
    Debug.Log("Success!" % ProDebugUtilities.Green);
    ```

* Custom Colors:
    ```csharp
    Color customColor = new Color(1f, 0f, 0f);  // Red color
    Debug.Log("Custom Color!" % new Colorize(customColor));
    Debug.Log("Custom Hex!" % new Colorize("#FFA500"));  // Orange color
    ```
  
* Text Formatting: You can apply bold or italic formatting to your text.
    ```csharp
    Debug.Log("Bold Text" % ProDebugUtilities.Bold);
    Debug.Log("Italic Text" % ProDebugUtilities.Italic);
    ```

* Custom Formats:
    ```csharp
    string customFormat = "b"; // Bold format
    Debug.Log("Custom Formatted Text" % new TextFormat(customFormat));
    ```

* ProDebug Editor: HMProDebug also includes a custom Editor window to allow easy selection of colors and formats without writing code.
  * Open the Editor window via the Unity menu: `Tools > HMProDebug > ProDebugEditor`.
  * Enter the text you want to log.
  * Select the color and format using dropdowns and input fields.
  * Click the "Show Log" button to see the formatted message in the console.

## Acknowledgments
Special thanks to the Unity community for their invaluable resources and tools.

For more information, visit the GitHub repository.
