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
    /// Логика взаимодействия для metro_buy.xaml
    /// </summary>
    public partial class metro_buy : Page
    {
        public metro_buy()
        {
            InitializeComponent();
        }

        private void metro_loaded(object sender, RoutedEventArgs e)
        {
            string path, a;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);
            label1.Content = Mass[2] + " поездок";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // opening the file and writing info in Mass
            string path;
            int sum, trip;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);

            // buying
            if (int.Parse(Mass[1]) > 30) {
                sum = int.Parse(Mass[1]) - 30;
                trip = int.Parse(Mass[2]) + 1;
                Mass[1] = sum.ToString();
                Mass[2] = trip.ToString();
            }
            

            //updating
            label1.Content = Mass[2] + " поездок";

            //writing in file
            File.WriteAllLines(path, Mass, Encoding.UTF8);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // opening the file and writing info in Mass
            string path;
            int sum, trip;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);

            // buying
            if (int.Parse(Mass[1]) > 120)
            {
                sum = int.Parse(Mass[1]) - 120;
                trip = int.Parse(Mass[2]) + 5;
                Mass[1] = sum.ToString();
                Mass[2] = trip.ToString();
            }


            //updating
            label1.Content = Mass[2] + " поездок";

            //writing in file
            File.WriteAllLines(path, Mass, Encoding.UTF8);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // opening the file and writing info in Mass
            string path;
            int sum, trip;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);

            // buying
            if (int.Parse(Mass[1]) > 260)
            {
                sum = int.Parse(Mass[1]) - 260;
                trip = int.Parse(Mass[2]) + 10;
                Mass[1] = sum.ToString();
                Mass[2] = trip.ToString();
            }


            //updating
            label1.Content = Mass[2] + " поездок";

            //writing in file
            File.WriteAllLines(path, Mass, Encoding.UTF8);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            string path;
            int days;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);

            if (Mass[6] == "yes")
            {
                days = int.Parse(Mass[7]) + 30;
                Mass[7] = days.ToString();
                File.WriteAllLines(path, Mass, Encoding.UTF8);
                label2.Content = "Успешно продлено!";
            }
            else
                label2.Content = "К сожалению у вас нет права льготного проезда";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            menu_back.Content = new user_menu();
        }
    }
}
