using Xamarin.Forms.Platform.UWP;

namespace FredrikHr.XamarinPlayground.AppSample.UWP
{
    public sealed partial class MainPage : WindowsPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new SharedLibrary.App());
        }
    }
}
