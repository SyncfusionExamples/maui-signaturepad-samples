namespace ByteArraySignature
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SfSignaturePad_DrawCompleted(object sender, EventArgs e)
        {
            StreamImageSource streamImageSource = (StreamImageSource)signaturePad.ToImageSource();
            System.Threading.CancellationToken cancellationToken =
            System.Threading.CancellationToken.None;
            Task<Stream> task = streamImageSource.Stream(cancellationToken);
            Stream stream = task.Result;
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            MemoryStream memoryStream = new MemoryStream(bytes);
            image.Source = ImageSource.FromStream(() => memoryStream);
        }
    }

}
