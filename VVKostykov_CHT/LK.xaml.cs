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
    /// Логика взаимодействия для LK.xaml
    /// </summary>
    public partial class LK : Page
    {
        public LK()
        {
            InitializeComponent();
        }

        private void LK_loaded(object sender, RoutedEventArgs e)
        {
            label.Content = Data.Value;
            string path, a;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);
            label7.Content = Mass[2];
            label8.Content = Mass[3];
            label9.Content = Mass[4];
            label10.Content = Mass[5];
            label11.Content = Mass[7];
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string path;
            int sum;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);

            sum = int.Parse(Mass[1]) + int.Parse(textBox.Text);
            Mass[1] = sum.ToString();

            File.WriteAllLines(path, Mass, Encoding.UTF8);
            label12.Content = "Успешно!";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string path;
            int ind = 0;
            path = "users\\lgot\\tickets_lgot.txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);

            for (int i = 0; i < Mass.Length; i++) {
                if (textBox1.Text == Mass[i])
                {
                    label14.Content = "Проездной найден! Теперь вы можете приобретать поездки по льготной цене";
                    ind = 1;
                    change_status();
                }                    
            }
            if(ind == 0)
                label14.Content = "К сожалению такой проездной не записан в нашей базе";
        }

        private void change_status() {
            string path;
            path = "users\\" + Data.Value + ".txt";
            string[] Mass = File.ReadAllLines(@path, System.Text.Encoding.Default);
            Mass[6] = "yes";
            File.WriteAllLines(path, Mass, Encoding.UTF8);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            menu_back.Content = new user_menu();
        }
    }
}
