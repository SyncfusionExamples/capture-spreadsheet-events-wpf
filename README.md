# How to capture the clipboard events of WPF SpreadSheet?

This sample illustrates how to capture the clipboard events of **WPF Spreadsheet**.

You can apture the clipboard operations using the [PreviewKeyDown](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.previewkeydown?view=netframework-4.6) event in the [WPF Spreadsheet](https://www.syncfusion.com/spreadsheet-editor-sdk/wpf-spreadsheet-editor) (SfSpreadsheet) control, in which the copy/paste could be captured using the keyboard shortcuts.

``` csharp
protected override void OnAttached()
{
    //Event Subscription
    this.AssociatedObject.PreviewKeyDown += AssociatedObject_PreviewKeyDown;
}
 
//Event Customization
private void AssociatedObject_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
{
    //To capture the clipboard(copy/paste) opeartions  
    if ((Keyboard.IsKeyDown(Key.LeftCtrl)) && e.Key == Key.C)
    {
        MessageBox.Show("Control+C Pressed");
    }
    else if ((Keyboard.IsKeyDown(Key.LeftCtrl)) && e.Key == Key.V)
    {
        MessageBox.Show("Control+V Pressed");
    }
}
```