# Maui-SignaturePad-Samples
This repository contains examples for the SfSignaturePad control in .NET MAUI (Multi-platform App UI) applications.

# Getting Started with .NET MAUI SignaturePad (SfSignaturePad)

This section explains the steps required to configure the .NET MAUI SignaturePad control and customize its elements.

# Adding a .NET MAUI SignaturePad reference

Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI SignaturePad to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.SignaturePad and then install it.

# Create a simple .NET MAUI SignaturePad

This section explains how to create a .NET MAUI SignaturePad and configure it. The control can be configured entirely in C# code or by the XAML markup.

# Creating the project

Create a new .NET MAUI application in Visual Studio

# Adding a .NET MAUI SignaturePad

Step 1: Add the NuGet to the project as discussed in the above reference section.

Step 2: Add the namespace as shown in the following code sample.

[XAML]

```xml
xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad"
```
Step 3: Set the control to content in ContentPage.

[XAML]

```xml
    <Frame HeightRequest="300" WidthRequest="400">
        <signaturePad:SfSignaturePad x:Name="signaturePad" 
                                     StrokeColor="GreenYellow" 
                                     BackgroundColor="White" />
    </Frame>
```