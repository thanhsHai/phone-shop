﻿using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
<<<<<<< Updated upstream
=======
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
using System.Windows.Forms.Design;
using MahApps.Metro.IconPacks;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Markup;
using Dark_Admin_Panel.UserControls;
using LiveCharts;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Wpf;

>>>>>>> Stashed changes

namespace DataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

<<<<<<< Updated upstream
            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "reza110@hotmail.com", Phone = "254-451-7893" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "deny.cast@gmail.com", Phone = "125-520-0141" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "lena.offi@hotmail.com", Phone = "320-658-9174" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Benjamin Caliword", Position = "Administrator", Email = "beni12@hotmail.com", Phone = "114-203-6258" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Sophia Muris", Position = "Coach", Email = "sophi.muri@gmail.com", Phone = "852-233-6854" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ali Pormand", Position = "Manager", Email = "alipor@yahoo.com", Phone = "968-378-4849" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Frank Underwood", Position = "Manager", Email = "frank@yahoo.com", Phone = "301-584-6966" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasi@hotmail.com", Phone = "817-320-5052" });

            members.Add(new Member { Number = "11", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            members.Add(new Member { Number = "12", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "reza110@hotmail.com", Phone = "254-451-7893" });
            members.Add(new Member { Number = "13", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "deny.cast@gmail.com", Phone = "125-520-0141" });
            members.Add(new Member { Number = "14", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" });
            members.Add(new Member { Number = "15", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "lena.offi@hotmail.com", Phone = "320-658-9174" });
            members.Add(new Member { Number = "16", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Benjamin Caliword", Position = "Administrator", Email = "beni12@hotmail.com", Phone = "114-203-6258" });
            members.Add(new Member { Number = "17", Character = "S", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Sophia Muris", Position = "Coach", Email = "sophi.muri@gmail.com", Phone = "852-233-6854" });
            members.Add(new Member { Number = "18", Character = "A", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ali Pormand", Position = "Manager", Email = "alipor@yahoo.com", Phone = "968-378-4849" });
            members.Add(new Member { Number = "19", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Frank Underwood", Position = "Manager", Email = "frank@yahoo.com", Phone = "301-584-6966" });
            members.Add(new Member { Number = "20", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasi@hotmail.com", Phone = "817-320-5052" });

            members.Add(new Member { Number = "21", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            members.Add(new Member { Number = "22", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "reza110@hotmail.com", Phone = "254-451-7893" });
            members.Add(new Member { Number = "23", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "deny.cast@gmail.com", Phone = "125-520-0141" });
            members.Add(new Member { Number = "24", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" });
            members.Add(new Member { Number = "25", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "lena.offi@hotmail.com", Phone = "320-658-9174" });
            members.Add(new Member { Number = "26", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Benjamin Caliword", Position = "Administrator", Email = "beni12@hotmail.com", Phone = "114-203-6258" });
            members.Add(new Member { Number = "27", Character = "S", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Sophia Muris", Position = "Coach", Email = "sophi.muri@gmail.com", Phone = "852-233-6854" });
            members.Add(new Member { Number = "28", Character = "A", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ali Pormand", Position = "Manager", Email = "alipor@yahoo.com", Phone = "968-378-4849" });
            members.Add(new Member { Number = "29", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Frank Underwood", Position = "Manager", Email = "frank@yahoo.com", Phone = "301-584-6966" });
            members.Add(new Member { Number = "30", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasi@hotmail.com", Phone = "817-320-5052" });

            membersDataGrid.ItemsSource = members;
=======
            lastClickedButton = dashboardButton;

            DisplayValue();
>>>>>>> Stashed changes
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
                //this.DragMove();
            }
        }
<<<<<<< Updated upstream
    }

    public class Member
    {
        public string Character { get; set; }
        public Brush BgColor { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
=======

        // -------------------------------------------------------Api logic------------------------------------------------------- //
        public static Product[] product;

        public static Order[] order;

        public static User[] user;

        public static BindingList<Product> productsBindingList;

        public static BindingList<Order> ordersBindingList;

        public static BindingList<User> usersBindingList;

        public static Revenue [] revenue;

        BindingList<Revenue> revenueBindingList;   

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            productsBindingList = await loadAllProducts();
            usersBindingList = await loadAllUsers();
            ordersBindingList = await loadAllOrders();
        }

        public async static Task<BindingList<Order>> loadAllOrders()
        {
            string apiUrl = "http://localhost:8000/api/order/";

            order = await GenericClass<Order>.CallApiAsync(apiUrl, order);

            ordersBindingList = new BindingList<Order>();

            for (int i = 0; i < order.Length; i++)
            {
                var orderTemp = new Order()
                {
                    _id = order[i]._id,
                    userName = order[i].userName,
                    productName = order[i].productName,
                    quantity = order[i].quantity,
                    date = order[i].date,
                };

                ordersBindingList.Add(orderTemp);
            }

            return ordersBindingList;
        }

        public async static Task<BindingList<User>> loadAllUsers()
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

        public async static Task<BindingList<Product>> loadAllProducts()
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

        // -------------------------------------------------------Button logic------------------------------------------------------- //

        public static Button lastClickedButton = null;

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    var screen = new AddProduct(productsBindingList);
                    screen.Show();
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
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
                    var screen = new EditProduct(membersDataGrid.SelectedIndex, productsBindingList);
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

        private void customerButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardSection.Visibility = Visibility.Collapsed;
            MainSection.Visibility = Visibility.Visible;

            LeftBorder.Background = new SolidColorBrush(Color.FromRgb(0xEF, 0xF2, 0xF7));

            //////////////////////////////////////////////////////////////////////////////////////////

            Button customerBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            customerButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            customerButton.Foreground = Brushes.White;

            lastClickedButton = customerBtn;

            //////////////////////////////////////////////////////////////////////////////////////////

            col01.Header = "Name";
            col02.Header = "Email";
            col03.Header = "User Name";
            col04.Header = "User Password";

            col01.Binding = new Binding("name");
            col02.Binding = new Binding("email");
            col03.Binding = new Binding("userName");
            col04.Binding = new Binding("userPassword");

            //////////////////////////////////////////////////////////////////////////////////////////

            loadUsers(usersBindingList);

            pagingCombobox.Visibility = Visibility.Visible;

            filterTextBox.Visibility = Visibility.Collapsed;
            startPriceTextBox.Visibility = Visibility.Collapsed;
            endPriceTextBox.Visibility = Visibility.Collapsed;
            filterIcon.Visibility = Visibility.Collapsed;
            saveFilterIcon.Visibility = Visibility.Collapsed;
            memberCount.Text = $"{usersBindingList.Count} members";
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardSection.Visibility = Visibility.Collapsed;
            MainSection.Visibility = Visibility.Visible;

            LeftBorder.Background = new SolidColorBrush(Color.FromRgb(0xEF, 0xF2, 0xF7));

            //////////////////////////////////////////////////////////////////////////////////////////

            Button oederBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            orderButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            orderButton.Foreground = Brushes.White;

            lastClickedButton = oederBtn;

            //////////////////////////////////////////////////////////////////////////////////////////

            col01.Header = "Date";
            col02.Header = "User Name";
            col03.Header = "Product Name";
            col04.Header = "Quantity";

            col01.Binding = new Binding("date");
            col02.Binding = new Binding("userName");
            col03.Binding = new Binding("productName");
            col04.Binding = new Binding("quantity");

            //////////////////////////////////////////////////////////////////////////////////////////

            loadOders(ordersBindingList);

            pagingCombobox.Visibility = Visibility.Visible;

            filterTextBox.Text = "Filter by date";

            filterTextBox.Visibility = Visibility.Visible;
            startPriceTextBox.Visibility = Visibility.Visible;
            endPriceTextBox.Visibility = Visibility.Visible;
            filterIcon.Visibility = Visibility.Visible;
            saveFilterIcon.Visibility = Visibility.Visible;

            memberCount.Text = $"{ordersBindingList.Count} members";
        }

        private void productButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardSection.Visibility = Visibility.Collapsed;
            MainSection.Visibility = Visibility.Visible;

            LeftBorder.Background = new SolidColorBrush(Color.FromRgb(0xEF, 0xF2, 0xF7));

            //////////////////////////////////////////////////////////////////////////////////////////

            Button productBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            productButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            productButton.Foreground = Brushes.White;

            lastClickedButton = productBtn;

            //////////////////////////////////////////////////////////////////////////////////////////

            col01.Header = "Name";
            col02.Header = "Price";
            col03.Header = "Producer";
            col04.Header = "Manufacture";

            col01.Binding = new Binding("name");
            col02.Binding = new Binding("price");
            col03.Binding = new Binding("producer");
            col04.Binding = new Binding("manufacture");

            //////////////////////////////////////////////////////////////////////////////////////////

            loadProducts(productsBindingList);

            pagingCombobox.Visibility = Visibility.Visible;

            filterTextBox.Text = "Filter by price";

            filterTextBox.Visibility = Visibility.Visible;
            startPriceTextBox.Visibility = Visibility.Visible;
            endPriceTextBox.Visibility = Visibility.Visible;
            filterIcon.Visibility = Visibility.Visible;
            saveFilterIcon.Visibility = Visibility.Visible;

            memberCount.Text = $"{productsBindingList.Count} members";
        }

        public async void DisplayValue()
        {
            productsBindingList = await loadAllProducts();

            int total01 = productsBindingList.Count();

            totalProducts.Text = total01.ToString();

            //////////////////////////////////////////////////////////////////////////////////////////

            ordersBindingList = await loadAllOrders();

            int total02 = ordersBindingList.Count();

            totalOrders.Text = total02.ToString();

            //////////////////////////////////////////////////////////////////////////////////////////

            int total03 = 0;

            for (int i = 0; i < ordersBindingList.Count; i++)
            {
                if (string.Compare(ordersBindingList[i].productName, productsBindingList[i].name) == 1)
                {
                    int price = productsBindingList[i].price;
                    total03 += ordersBindingList[i].quantity * price;
                }
            }

            totalRevenue.Text = $"{total03.ToString()}$";

            //////////////////////////////////////////////////////////////////////////////////////////

            BindingList<Order> sortResults = new BindingList<Order>(ordersBindingList.OrderByDescending(o => o.quantity).ToList());

            BindingList<Order> temp = new BindingList<Order>(sortResults.Take(5).ToList());

            DashboardDataGrid.ItemsSource = temp;
        }

        async void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            MainSection.Visibility = Visibility.Collapsed;
            DashboardSection.Visibility = Visibility.Visible;
            productDashboard.Visibility = Visibility.Visible;
            chart.Visibility = Visibility.Collapsed;

            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(1, 0);
            gradientBrush.EndPoint = new Point(0, 1);
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0x41, 0x51, 0x8F), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0x2C, 0x38, 0x6C), 1));

            LeftBorder.Background = gradientBrush;

            //////////////////////////////////////////////////////////////////////////////////////////

            Button dashboardBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            dashboardButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            dashboardButton.Foreground = Brushes.White;

            lastClickedButton = dashboardBtn;

            //////////////////////////////////////////////////////////////////////////////////////////

            DisplayValue();
        }

        private async void analysisButton_Click(object sender, RoutedEventArgs e)
        {
            MainSection.Visibility = Visibility.Collapsed;
            DashboardSection.Visibility = Visibility.Visible;
            productDashboard.Visibility = Visibility.Collapsed;
            chart.Visibility = Visibility.Visible;

            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(1, 0);
            gradientBrush.EndPoint = new Point(0, 1);
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0x41, 0x51, 0x8F), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0x2C, 0x38, 0x6C), 1));

            LeftBorder.Background = gradientBrush;

            //////////////////////////////////////////////////////////////////////////////////////////

            DisplayValue();

            //////////////////////////////////////////////////////////////////////////////////////////

            Button analysisBtn = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.Background = Brushes.Transparent;
                lastClickedButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD0C0FF"));
            }

            analysisButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B5CD6"));
            analysisButton.Foreground = Brushes.White;

            lastClickedButton = analysisBtn;
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new ExitConfirmation();
            screen.Show();
        }

        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    BindingList<Product> searchProduct = new BindingList<Product>();

                    string temp = textBoxSearch.Text;

                    if (!string.IsNullOrEmpty(temp))
                    {
                        for (int i = 0; i < productsBindingList.Count; i++)
                        {
                            bool contains = productsBindingList[i].name.Contains(temp);

                            if (contains)
                            {
                                searchProduct.Add(productsBindingList[i]);
                            }
                        }

                        membersDataGrid.ItemsSource = searchProduct;

                        pagingCombobox.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        pagingCombobox.Visibility = Visibility.Visible;

                        loadProducts(productsBindingList);
                    }
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    BindingList<Order> searchOrder = new BindingList<Order>();

                    string temp = textBoxSearch.Text;

                    if (!string.IsNullOrEmpty(temp))
                    {
                        for (int i = 0; i < ordersBindingList.Count; i++)
                        {
                            bool contains = ordersBindingList[i].userName.Contains(temp);

                            if (contains)
                            {
                                searchOrder.Add(ordersBindingList[i]);
                            }
                        }

                        membersDataGrid.ItemsSource = searchOrder;

                        pagingCombobox.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        pagingCombobox.Visibility = Visibility.Visible;

                        loadOders(ordersBindingList);
                    }
                }
                else
                {
                    BindingList<User> searchUser = new BindingList<User>();

                    string temp = textBoxSearch.Text;

                    if (!string.IsNullOrEmpty(temp))
                    {
                        for (int i = 0; i < usersBindingList.Count; i++)
                        {
                            bool contains = usersBindingList[i].userName.Contains(temp);

                            if (contains)
                            {
                                searchUser.Add(usersBindingList[i]);
                            }
                        }

                        membersDataGrid.ItemsSource = searchUser;

                        pagingCombobox.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        pagingCombobox.Visibility = Visibility.Visible;

                        loadUsers(usersBindingList);
                    }
                }
            }
        }

        private void sortCol01Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    productsBindingList = GenericClass<Product>.sortChange(sender, e, productsBindingList, "name");
                    loadProducts(productsBindingList);
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    ordersBindingList = GenericClass<Order>.sortChange(sender, e, ordersBindingList, "date");
                    loadOders(ordersBindingList);
                }
                else
                {
                    usersBindingList = GenericClass<User>.sortChange(sender, e, usersBindingList, "name");
                    loadUsers(usersBindingList);
                }
            }
        }

        private void sortCol02Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    productsBindingList = GenericClass<Product>.sortChange(sender, e, productsBindingList, "price");
                    loadProducts(productsBindingList);
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    ordersBindingList = GenericClass<Order>.sortChange(sender, e, ordersBindingList, "userName");
                    loadOders(ordersBindingList);
                }
                else
                {
                    usersBindingList = GenericClass<User>.sortChange(sender, e, usersBindingList, "email");
                    loadUsers(usersBindingList);
                }
            }
        }

        private void sortCol03Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    productsBindingList = GenericClass<Product>.sortChange(sender, e, productsBindingList, "producer");
                    loadProducts(productsBindingList);
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    ordersBindingList = GenericClass<Order>.sortChange(sender, e, ordersBindingList, "productName");
                    loadOders(ordersBindingList);
                }
                else
                {
                    usersBindingList = GenericClass<User>.sortChange(sender, e, usersBindingList, "userName");
                    loadUsers(usersBindingList);
                }
            }
        }

        private void sortCol04Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    productsBindingList = GenericClass<Product>.sortChange(sender, e, productsBindingList, "manufacture");
                    loadProducts(productsBindingList);
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    ordersBindingList = GenericClass<Order>.sortChange(sender, e, ordersBindingList, "quantity");
                    loadOders(ordersBindingList);
                }
                else
                {
                    usersBindingList = GenericClass<User>.sortChange(sender, e, usersBindingList, "userPassword");
                    loadUsers(usersBindingList);
                }
            }
        }

        // -------------------------------------------------------Pagging------------------------------------------------------- //

        int _rowsPerPage = 5;
        int _totalPages = -1;
        int _totalItems = -1;
        int _currentPage = 1;

        public void loadProducts(BindingList<Product> products)
        {
            BindingList<Product> source = new BindingList<Product>();

            var data = products.Skip((_currentPage - 1) * _rowsPerPage).Take(_rowsPerPage);

            foreach (var item in data)
            {
                source.Add(item);
            }

            membersDataGrid.ItemsSource = source;

            _totalItems = products.Count;

            _totalPages = (_totalItems / _rowsPerPage) + ((_totalItems % _rowsPerPage == 0) ? 0 : 1);

            var pageInfos = new List<object>();

            for (int i = 1; i <= _totalPages; i++)
            {
                pageInfos.Add(new { Page = i, Total = _totalPages });
            }

            pagingCombobox.ItemsSource = pageInfos;
            pagingCombobox.SelectedIndex = _currentPage - 1;

            pagingCombobox.Visibility = Visibility.Visible;
        }

        public void loadOders(BindingList<Order> orders)
        {
            BindingList<Order> source = new BindingList<Order>();

            var data = orders.Skip((_currentPage - 1) * _rowsPerPage).Take(_rowsPerPage);

            foreach (var item in data)
            {
                source.Add(item);
            }

            membersDataGrid.ItemsSource = source;

            _totalItems = orders.Count;

            _totalPages = (_totalItems / _rowsPerPage) + ((_totalItems % _rowsPerPage == 0) ? 0 : 1);

            var pageInfos = new List<object>();

            for (int i = 1; i <= _totalPages; i++)
            {
                pageInfos.Add(new { Page = i, Total = _totalPages });
            }

            pagingCombobox.ItemsSource = pageInfos;
            pagingCombobox.SelectedIndex = _currentPage - 1;

            pagingCombobox.Visibility = Visibility.Visible;
        }

        public void loadUsers(BindingList<User> users)
        {
            BindingList<User> source = new BindingList<User>();

            var data = users.Skip((_currentPage - 1) * _rowsPerPage).Take(_rowsPerPage);

            foreach (var item in data)
            {
                source.Add(item);
            }

            membersDataGrid.ItemsSource = source;

            _totalItems = users.Count;

            _totalPages = (_totalItems / _rowsPerPage) + ((_totalItems % _rowsPerPage == 0) ? 0 : 1);

            var pageInfos = new List<object>();

            for (int i = 1; i <= _totalPages; i++)
            {
                pageInfos.Add(new { Page = i, Total = _totalPages });
            }

            pagingCombobox.ItemsSource = pageInfos;
            pagingCombobox.SelectedIndex = _currentPage - 1;

            pagingCombobox.Visibility = Visibility.Visible;
        }

        private void pagingCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dynamic info = pagingCombobox.SelectedItem;

            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    if (info != null)
                    {
                        if (info?.Page != _currentPage)
                        {
                            _currentPage = info?.Page;
                            loadProducts(productsBindingList);
                        }
                    }
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    if (info != null)
                    {
                        if (info?.Page != _currentPage)
                        {
                            _currentPage = info?.Page;
                            loadOders(ordersBindingList);
                        }
                    }
                }
                else
                {
                    if (info != null)
                    {
                        if (info?.Page != _currentPage)
                        {
                            _currentPage = info?.Page;
                            loadUsers(usersBindingList);
                        }
                    }
                }
            }
        }
        private void saveFilter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Name.ToString() == "productButton")
                {
                    BindingList<Product> temp = new BindingList<Product>();

                    foreach (var item in productsBindingList)
                    {
                        if (item.price >= int.Parse(startPriceTextBox.Text) && item.price <= int.Parse(endPriceTextBox.Text))
                        {
                            temp.Add(item);
                        }
                    }

                    membersDataGrid.ItemsSource = temp;

                    pagingCombobox.Visibility = Visibility.Collapsed;
                }
                else if (lastClickedButton.Name.ToString() == "orderButton")
                {
                    BindingList<Order> temp = new BindingList<Order>();

                    DateTime start = DateTime.Parse(startPriceTextBox.Text);
                    DateTime end = DateTime.Parse(endPriceTextBox.Text);

                    foreach (var item in ordersBindingList)
                    {
                        if (DateTime.Parse(item.date) >= start && DateTime.Parse(item.date) <= end)
                        {
                            temp.Add(item);
                        }
                    }

                    membersDataGrid.ItemsSource = temp;

                    pagingCombobox.Visibility = Visibility.Collapsed;
                }
            }
        }
        private async void refresh_Click(object sender, RoutedEventArgs e)
        {
            productsBindingList = await loadAllProducts();
            ordersBindingList = await loadAllOrders();
            usersBindingList = await loadAllUsers();
            loadProducts(productsBindingList);
            loadOders(ordersBindingList);
            loadUsers(usersBindingList);
            DisplayValue();
        }
        private async void saveDateButton_Click(object sender, RoutedEventArgs e)
        {
            string start = StartDate.Text;
            string end = EndDate.Text;
            string[] inputDates = { start, end };

            // Danh sách để lưu trữ kết quả chuyển đổi
            List<string> outputDates = new List<string>();

            // Các định dạng ngày có thể xuất hiện
            string[] dateFormats = { "MM/dd/yyyy", "MM/d/yyyy", "M/d/yyyy" };

            // Chuyển đổi từng chuỗi ngày
            foreach (var inputDate in inputDates)
            {
                // Chuyển đổi chuỗi thành đối tượng DateTime
                DateTime dateTime;

                // Thử chuyển đổi với tất cả các định dạng ngày có thể xuất hiện
                if (DateTime.TryParseExact(inputDate, dateFormats, null, System.Globalization.DateTimeStyles.None, out dateTime))
                {
                    // Chuyển đổi ngày thành chuỗi theo định dạng d/MM/yyyy
                    string outputDate = dateTime.ToString("d/MM/yyyy");

                    // Thêm vào danh sách kết quả
                    outputDates.Add(outputDate);
                }
                else
                {
                    // Xuất thông báo lỗi nếu không thể chuyển đổi
                    Console.WriteLine($"Ngày không hợp lệ: {inputDate}");
                }
            }

            // In kết quả
            string date1 = outputDates[0];
            string date2 = outputDates[1];

            revenue = await GenericClass<Revenue>.getRevenceByDate(date1, date2, revenue);

            revenueBindingList = new BindingList<Revenue>();

            for (int i = 0; i < revenue.Length; i++)
            {
                var revenueTemp = new Revenue()
                {
                    revenue = revenue[i].revenue,
                    date = revenue[i].date
                };

                revenueBindingList.Add(revenueTemp);
            }

            var valuesColChart = new ChartValues<int>();
            var valuesDay = new ChartValues<string>();
            foreach (var item in revenueBindingList)
            {
                valuesColChart.Add((int)item.revenue);
            }

            foreach (var item in revenueBindingList)
            {
                valuesDay.Add((string)item.date);
            }
            chartbehind.Series = new SeriesCollection();
            chartbehind.AxisX = new AxesCollection();

            chartbehind.Series.Add(new ColumnSeries()
            {
                Fill = Brushes.Chocolate,
                Title = "Revenue by date: ",
                Values = valuesColChart
            });

            chartbehind.AxisX.Add(
                new Axis()
                {
                    Foreground = Brushes.Black,
                    Title = "Date",
                    Labels = valuesDay
                });
            Title.Text = "Showing date view";
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

            public static BindingList<T> sortChange(object sender, MouseButtonEventArgs e, BindingList<T> data, string parameter)
            {
                if (sender is FrameworkElement iconElement && iconElement.Parent is StackPanel stackPanel)
                {
                    foreach (var child in stackPanel.Children)
                    {
                        if (child is PackIconMaterial packIcon)
                        {
                            // Đọc hoặc thiết lập thuộc tính Kind
                            PackIconMaterialKind iconKind = packIcon.Kind;

                            // Xử lý logic dựa trên giá trị của Kind
                            if (iconKind == PackIconMaterialKind.SortAscending)
                            {
                                packIcon.Kind = PackIconMaterialKind.SortDescending;

                                var sortedList = data.OrderBy(item => typeof(T).GetProperty(parameter)?.GetValue(item, null)).ToList();

                                data = new BindingList<T>(sortedList);
                            }
                            else
                            {
                                packIcon.Kind = PackIconMaterialKind.SortAscending;

                                var sortedList = data.OrderByDescending(item => typeof(T).GetProperty(parameter)?.GetValue(item, null)).ToList();

                                data = new BindingList<T>(sortedList);
                            }
                        }
                    }
                }
                return data;
            }

            public static async Task<T[]> getRevenceByDate(string dateStart, string dateEnd, T[] data)
            {
                try
                {
                    var date = new
                    {
                        start = dateStart,
                        end = dateEnd,
                    };

                    string apiUrl = "http://localhost:8000/api/revenue/date";

                    // Chuyển đối tượng Product thành chuỗi JSON
                    string jsonData = JsonConvert.SerializeObject(date);

                    // Tạo HttpClient để thực hiện cuộc gọi POST
                    using (HttpClient client = new HttpClient())
                    {
                        // Tạo nội dung của yêu cầu POST với kiểu dữ liệu là JSON
                        StringContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

                        // Thực hiện cuộc gọi POST
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                        // Kiểm tra xem cuộc gọi API có thành công không (mã trạng thái 2xx)
                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();

                            dynamic jsonDataAfter = JsonConvert.DeserializeObject(responseData);

                            if (jsonDataAfter.data != null)
                            {
                                // Kiểm tra xem 'data' có phải là mảng không
                                if (jsonDataAfter.data is JArray dataArray)
                                {
                                    // Deserializing mảng 'data' thành mảng Product
                                    data = dataArray.ToObject<T[]>();
                                    
                                    if (jsonDataAfter.data != null)
                                    {
                                        data = JsonConvert.DeserializeObject<T[]>(jsonDataAfter.data);
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
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                return data;
            }
        }
>>>>>>> Stashed changes
    }
}