using GTK_Button_bug;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace GTKSample
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            global::Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.Show();

            Gtk.Application.Run();
        }
    }
}
