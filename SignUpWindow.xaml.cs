using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void orLoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private async void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var name = string.Empty;
                var username = UsernameTextBox.Text;
                var _email = EmailTextBox.Text;
                var password = PasswordBox.Password;
                var repeatPassword = RepeatPasswordBox.Password;

                // Optional: Validate the inputs (e.g., check if passwords match)

                if (password != repeatPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                HttpClient client = new HttpClient();
                var model = new
                {
                    name = username,
                    userName = username,
                    email = _email,
                    userPassword = password
                };

                StringContent content = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("http://localhost:8000/api/auth/register", content);

                
                string result = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registration successful", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    // Optionally, navigate to login window
                }
                else
                {
                    var errorResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
                    if (errorResponse.ContainsKey("message") && errorResponse["message"].ToString().Contains("already exists"))
                    {
                        MessageBox.Show("Username or email already exists. Please use a different one.", "Registration Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Registration failed: {result}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
