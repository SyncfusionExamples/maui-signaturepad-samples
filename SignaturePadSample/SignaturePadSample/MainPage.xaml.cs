using Syncfusion.Maui.Core.Internals;

namespace SignaturePadSample
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            signaturePad.ToImageSource();
            signaturePad.SaveAsImage("Sign");
        }
    }

}
