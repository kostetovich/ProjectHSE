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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string login, pass, path;
            login = textbox_login.Text;
            pass = textbox_pass.Text;
            path = "users\\" + login + ".txt";
            //FileStream file1 = new FileStream("users\\new_file.txt", FileMode.Open); //создаем файловый поток
            //StreamReader reader = new StreamReader(file1);

            if (File.Exists(path))
            {
                string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);
                if (pass == Mass[0])
                {
                    frame.Content = new user_menu();
                    Data.Value = login;
                    //File.Create("users\\new_file.txt");
                }
                else
                    error.Content = "Неверный пароль!";
            }
            else
                error.Content = "Такого пользователя не существует!";
            
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new Register();
        }
    }
}
