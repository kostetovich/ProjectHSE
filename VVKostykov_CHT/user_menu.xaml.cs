using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text;
using System.IO;

namespace VVKostykov_CHT
{
    /// <summary>
    /// Логика взаимодействия для user_menu.xaml
    /// </summary>
    public partial class user_menu : Page
    {

        public user_menu()
        {
            InitializeComponent();

        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            metro.Content = new metro_buy();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            metro.Content = new bus_buy();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            metro.Content = new trall_buy();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            metro.Content = new tramm_buy();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            metro.Content = new LK();
        }

        private void lk_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void loaded_page(object sender, RoutedEventArgs e)
        {
            string path, a;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);
            a = Mass[0];
            label3.Content = Data.Value;
            label2.Content = Mass[1] + " руб.";
        }
    }
}
