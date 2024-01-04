using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Windows.Data;


namespace DataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool IsMaximize = false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximize)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximize = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximize = true;
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        // Api logic
        public static Product[] product;

        public static Order[] order;

        public static User[] user;

        BindingList<Product> productsBindingList;

        BindingList<Order> ordersBindingList;

        BindingList<User> usersBindingList;

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            productsBindingList = await loadAllProducts(); 
            usersBindingList = await loadAllUsers();
            ordersBindingList = await loadAllOrders();
        }

        public async Task<BindingList<Order>> loadAllOrders()
        {
            string apiUrl = "http://localhost:8000/api/order/";

            order = await GenericClass<Order>.CallApiAsync(apiUrl, order);

            ordersBindingList = new BindingList<Order>();

            for (int i = 0; i < order.Length; i++)
            {
                var orderTemp = new Order()
                {
                    _id = order[i]._id,
                    userId = usersBindingList[i]._id, 
                    productId = productsBindingList[i]._id, 
                    quantity = order[i].quantity,
                    date = order[i].date,
                };

                MessageBox.Show($"user id: {orderTemp.userId}");

                ordersBindingList.Add(orderTemp);
            }

            return ordersBindingList;
        }

        public async Task<BindingList<User>> loadAllUsers()
        {
            string apiUrl = "http://localhost:8000/api/user/";

            user = await GenericClass<User>.CallApiAsync(apiUrl, user);

            usersBindingList = new BindingList<User>();

            for (int i = 0; i < user.Length; i++)
            {
                var userTemp = new User()
                {
                    _id = user[i]._id,      
                    name = user[i].name,
                    email = user[i].email,
                    userName = user[i].userName,
                    userPassword = user[i].userPassword,
                };

                usersBindingList.Add(userTemp);
            }

            return usersBindingList;
        }

        public async Task<BindingList<Product>> loadAllProducts()
        {
            string apiUrl = "http://localhost:8000/api/product/";

            product = await GenericClass<Product>.CallApiAsync(apiUrl, product);

            productsBindingList = new BindingList<Product>();

            for (int i = 0; i < product.Length; i++)
            {
                var productTemp = new Product()
                {
                    _id = product[i]._id,
                    name = product[i].name,
                    price = product[i].price,
                    producer = product[i].producer,
                    manufacture = product[i].manufacture
                };

                productsBindingList.Add(productTemp);
            }

            return productsBindingList;
        }

        // Button logic
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if(lastClickedButton != null)
            {
                if(lastClickedButton.Name.ToString() == "productButton")
                {
                    var screen = new AddProduct(productsBindingList);
                    screen.Show();
                }
                else if(lastClickedButton.Name.ToString() == "orderButton")
                {
                    var screen = new AddOrder(ordersBindingList);
                    screen.Show();
                }
                else
                {
                    var screen = new AddUser(usersBindingList);
                    screen.Show();
                }
            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new ExitConfirmation();
            screen.Show();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    var screen = new EditProduct(membersDataGrid.SelectedIndex ,productsBindingList);
                    screen.Show();
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    var screen = new EditOrder(membersDataGrid.SelectedIndex, ordersBindingList);
                    screen.Show();
                }
                else
                {
                    var screen = new EditUser(membersDataGrid.SelectedIndex, usersBindingList);
                    screen.Show();
                }
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new DeleteConfirmation(membersDataGrid.SelectedIndex, productsBindingList);
            screen.Show();
        }

        public static Button lastClickedButton = null;
        private void customerButton_Click(object sender, RoutedEventArgs e)
        {
            Button customerBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            customerBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            customerBtn.Foreground = Brushes.White;

            lastClickedButton = customerBtn;

            col01.Header = "Name";
            col02.Header = "Email";
            col03.Header = "User Name";
            col04.Header = "User Password";

            col01.Binding = new Binding("name");
            col02.Binding = new Binding("email");
            col03.Binding = new Binding("userName");
            col04.Binding = new Binding("userPassword");

            membersDataGrid.ItemsSource = usersBindingList;
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            Button oederBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            oederBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            oederBtn.Foreground = Brushes.White;

            lastClickedButton = oederBtn;

            col01.Header = "Date";
            col02.Header = "User ID";
            col03.Header = "Product ID";
            col04.Header = "Quantity";

            col01.Binding = new Binding("date");
            col02.Binding = new Binding("userId");
            col03.Binding = new Binding("productId");
            col04.Binding = new Binding("quantity");

            membersDataGrid.ItemsSource = ordersBindingList;
        }

        private void productButton_Click(object sender, RoutedEventArgs e)
        {
            Button productBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            productBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            productBtn.Foreground = Brushes.White;

            lastClickedButton = productBtn;

            col01.Header = "Name";
            col02.Header = "Price";
            col03.Header = "Producer";
            col04.Header = "Manufacture";

            col01.Binding = new Binding("name");
            col02.Binding = new Binding("price");
            col03.Binding = new Binding("producer");
            col04.Binding = new Binding("manufacture");

            membersDataGrid.ItemsSource = productsBindingList;
        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            Button dashboardBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            dashboardBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            dashboardBtn.Foreground = Brushes.White;

            lastClickedButton = dashboardBtn;
        }

        private void analysisButton_Click(object sender, RoutedEventArgs e)
        {
            Button analysisBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            analysisBtn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            analysisBtn.Foreground = Brushes.White;

            lastClickedButton = analysisBtn;
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeRestoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                MaximizeIcon.Visibility = Visibility.Visible;
                RestoreIcon.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                MaximizeIcon.Visibility = Visibility.Collapsed;
                RestoreIcon.Visibility = Visibility.Visible;
            }
        }
        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new LogoutConfirmation();
            screen.Show();
        }
    }
    public static class GenericClass<T>
    {
        public static async Task<T[]> CallApiAsync(string apiUrl, T[] data)
        {
            try
            {
                // Log thời điểm bắt đầu cuộc gọi
                Console.WriteLine($"Calling API at: {DateTime.Now}");

                using (HttpClient client = new HttpClient())
                {
                    // Gọi API và nhận phản hồi
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Kiểm tra xem cuộc gọi API có thành công không (mã trạng thái 200 OK)
                    if (response.IsSuccessStatusCode)
                    {
                        // Add the authorization header with the saved token
                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.UserToken);
                        // Đọc dữ liệu từ phản hồi
                        string responseData = await response.Content.ReadAsStringAsync();

                        // Xử lý dữ liệu theo nhu cầu của bạn
                        Console.WriteLine($"API Response: {responseData}");

                        dynamic jsonData = JsonConvert.DeserializeObject(responseData);

                        if (jsonData.data != null)
                        {
                            // Kiểm tra xem 'data' có phải là mảng không
                            if (jsonData.data is JArray dataArray)
                            {
                                // Deserializing mảng 'data' thành mảng Product
                                data = dataArray.ToObject<T[]>();

                                if (jsonData.data != null)
                                {
                                    data = JsonConvert.DeserializeObject<T[]>(jsonData.data);
                                    return data;
                                }
                            }
                            else
                            {
                                MessageBox.Show("The property 'data' is not an array.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid JSON structure. There is no 'data' attribute.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"API Call failed. Status Code: {response.StatusCode}");
                    }
                }

                // Log thời điểm kết thúc cuộc gọi
                Console.WriteLine($"API Call finished at: {DateTime.Now}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return data;
        }
    }
}