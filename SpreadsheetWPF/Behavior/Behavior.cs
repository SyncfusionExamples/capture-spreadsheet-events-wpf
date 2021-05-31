using Syncfusion.UI.Xaml.Spreadsheet;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace CellFormatting.Behavior
{
    class Behavior:Behavior<SfSpreadsheet>
    {
        protected override void OnAttached()
        {
            //Event Subscription
            this.AssociatedObject.PreviewKeyDown += AssociatedObject_PreviewKeyDown;
        }

        //Customization
        private void AssociatedObject_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //To capture clipboard(copy/paste) opeartions  
            if ((Keyboard.IsKeyDown(Key.LeftCtrl)) && e.Key == Key.C)
            {
                MessageBox.Show("Control+C Pressed");
            }
            else if ((Keyboard.IsKeyDown(Key.LeftCtrl)) && e.Key == Key.V)
            {
                MessageBox.Show("Control+V Pressed");
            }
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.PreviewKeyDown -= AssociatedObject_PreviewKeyDown;
        }
    }
}
