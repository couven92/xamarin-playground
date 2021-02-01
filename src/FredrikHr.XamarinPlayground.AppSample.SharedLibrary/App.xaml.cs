using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FredrikHr.XamarinPlayground.AppSample.SharedLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
