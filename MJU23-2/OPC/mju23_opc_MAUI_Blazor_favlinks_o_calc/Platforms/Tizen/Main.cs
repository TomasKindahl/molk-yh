using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace mju23_opc_MAUI_Blazor_favlinks_o_calc
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}