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

namespace Алексеев
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // описываем переменные
            int x, y, c,a,b;
            // пытаемся преобразовать строку из TextBox.Text в целое число
            bool result1 = int.TryParse(TextBox1.Text, out x);
            if (result1 == false)
            // если возникла ошибка преобразования то 
            // выводим сообщение и заканчиваем работу метода
            {
                MessageBox.Show("Неверный формат числа " + TextBox1.Text + "!");
                return; // заканчиваем работу метода
            }
            // пытаем преобразовать строку из textBox2.Text в целое число
            bool result2 = int.TryParse(TextBox2.Text, out y);
            if (result2 == false) // если возникла ли ошибка преобразования
            {                  // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + TextBox2.Text + "!");
                return; // заканчиваем работу метода
            }
            a = 5 * x;
            b = 3 * y;
            c = (a - b) * 2;
            string cStr = c.ToString();
            Label1.Content = cStr;
            return; // заканчиваем работу метода

        }
    }
}
