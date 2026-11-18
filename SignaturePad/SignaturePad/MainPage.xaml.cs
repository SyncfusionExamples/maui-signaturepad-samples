using System.Text;
namespace SignaturePad
{
    public partial class MainPage : ContentPage
    {
        private string? savedStrokeData;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSaveClicked(object? sender, EventArgs e)
        {
            savedStrokeData = signaturePad.ExportStrokeData();
            statusLabel.Text = string.IsNullOrWhiteSpace(savedStrokeData) || signaturePad.IsEmpty
                ? "Nothing to save - pad is empty."
                : "Saved stroke data (point format) in memory.";
        }

        private void OnClearClicked(object? sender, EventArgs e)
        {
            signaturePad.Clear();
            statusLabel.Text = "Pad cleared. Reload to restore the saved signature.";
        }

        private void OnLoadFromStringClicked(object? sender, EventArgs e)
        {
            if (savedStrokeData == null)
            {
                statusLabel.Text = "No saved data yet. Draw and press Save first.";
                return;
            }

            signaturePad.LoadFromStrokeData(savedStrokeData);
            statusLabel.Text = "Loaded from string stroke data.";
        }

        private void OnLoadFromStreamClicked(object? sender, EventArgs e)
        {
            if (savedStrokeData == null)
            {
                statusLabel.Text = "No saved data yet. Draw and press Save first.";
                return;
            }

            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(savedStrokeData));
            signaturePad.LoadFromStrokeData(stream);
            statusLabel.Text = "Loaded from stream stroke data.";
        }
    }
}
