using System;
using System.Reflection;

using FredrikHr.XamarinPlayground.AppSample.SharedLibrary;

using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

using GtkLib = Gtk;

namespace FredrikHr.XamarinPlayground.AppSample.Gtk
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            GtkLib.Application.Init(
                Assembly.GetEntryAssembly()?.GetName().Name ??
                typeof(Program).Namespace!,
                ref args);
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);

            GtkLib.Application.Run();

        }
    }
}
