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
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string login, pass, pass_ver;

            login = textBox.Text;
            pass = textBox1.Text;
            pass_ver = textBox2.Text;

            if (pass == pass_ver) {
                string path;
                path = "users\\" + login + ".txt";
                string[] mass = new string[8] {pass, "0", "0", "0", "0", "0", "no", "0" };
                File.WriteAllLines(path, mass, Encoding.UTF8);

            }
        }
    }
}
