using System;

using FredrikHr.XamarinPlayground.AppSample.SharedLibrary;

using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace FredrikHr.XamarinPlayground.AppSample.Wpf
{
    public static class Program
   {
       [STAThread]
       public static int Main()
       {
           var application = new System.Windows.Application();
           Forms.Init();
           var formsApplicationPage = new FormsApplicationPage();
           formsApplicationPage.LoadApplication(new App());
           return application.Run(formsApplicationPage);
       }
   }
}
