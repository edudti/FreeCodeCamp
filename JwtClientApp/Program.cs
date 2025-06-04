using System;
using System.Net.Http;
using System.Windows.Forms;
using JwtClientApp.Services;

namespace JwtClientApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5000") };
            ITokenApiClient apiClient = new TokenApiClient(httpClient);

            Application.Run(new Form1(apiClient));
        }
    }
}
