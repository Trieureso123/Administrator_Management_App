using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    internal static class Program
    {
        public static string? ConnectionString;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder().AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            ConnectionString = configuration.GetSection("ConnectionStrings").GetSection("GameWebsiteDb").Value;

            Application.Run(new Login_modifier());
        }
    }
}
