# Capture the clipboard events of WPF SpreadSheet

This sample illustrates how to capture the clipboard events of **WPF Spreadsheet**.

You can capture the clipboard operations using the [PreviewKeyDown](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.previewkeydown?view=netframework-4.6) event in the [WPF Spreadsheet](https://www.syncfusion.com/spreadsheet-editor-sdk/wpf-spreadsheet-editor) (SfSpreadsheet) control, in which the copy/paste could be captured using the keyboard shortcuts.

## Prerequisites

Before running this project, ensure you have the following installed:

- **Visual Studio** 2019 or later
- **.NET Framework** 4.6.2 or greater or **.NET Core** 8.0 or greater

## Technologies Used

- **WPF** (Windows Presentation Foundation) + **Syncfusion Spreadsheet**

## Getting Started

### 1. Clone the Repository

Clone this repository to your local machine:

```bash
git clone https://github.com/SyncfusionExamples/capture-spreadsheet-events-wpf
cd capture-spreadsheet-events-wpf
```

### 2. Install Dependencies

Install the required Syncfusion WPF Spreadsheet packages as dependencies:

```bash
dotnet add package Syncfusion.SfSpreadsheet.WPF
dotnet add package Syncfusion.SfSpreadsheetHelper.WPF
```

Alternatively, you can restore packages using:

```bash
dotnet restore
```

### 3. Run the Application

Run the project and test the feature directly from the WPF app:

```bash
dotnet run
```

Or open the solution in Visual Studio and press `F5` to build and run the application.

## Resources

- https://help.syncfusion.com/document-processing/excel/spreadsheet/wpf/getting-started
- https://support.syncfusion.com/kb/article/11075/how-to-capture-the-clipboard-events-of-wpf-spreadsheet
