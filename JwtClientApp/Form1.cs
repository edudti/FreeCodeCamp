using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using JwtClientApp.Services;
using DevExpress.XtraEditors;

namespace JwtClientApp
{
    public partial class Form1 : Form
    {
        private readonly ITokenApiClient _apiClient;

        public Form1(ITokenApiClient apiClient)
        {
            _apiClient = apiClient;
            InitializeComponent();
        }

        private async void buttonGetToken_Click(object sender, EventArgs e)
        {
            textBoxResponse.Text = string.Empty;
            var username = textBoxUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                XtraMessageBox.Show("El campo de usuario es obligatorio.");
                return;
            }

            try
            {
                buttonGetToken.Enabled = false;
                var result = await _apiClient.RequestTokenAsync(username);
                textBoxResponse.Text = result;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                buttonGetToken.Enabled = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = string.Empty;
            textBoxResponse.Text = string.Empty;
        }
    }
}
