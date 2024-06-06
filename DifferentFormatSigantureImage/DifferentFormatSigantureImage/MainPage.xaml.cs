using Syncfusion.Maui.Core.Internals;

namespace DifferentFormatSigantureImage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            //To save image as .png format
            signaturePad.SaveAsImage("sign");

            //To save image as .jpeg format
            signaturePad.SaveAsImage("sign.jpeg");
        }
    }

}
