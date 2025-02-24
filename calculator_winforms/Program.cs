using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_winforms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"C:\Users\glkru\OneDrive\Desktop\prj\Project_cpo\User_setup\Logs\myapp.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();


            Log.Information("App start");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new calculator());
        }
    }
}
