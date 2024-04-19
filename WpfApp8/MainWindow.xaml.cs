using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //начальные значения
        private bool counting = false; //TextBox пустой 
        private int count = 0; //число 0
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //проверка TextBox
            if (counting)
            {
                counting = false; //TextBox пустой
            }
            else
            {
                counting = true; //в TextBox выводятся числа
                Count();
            }
            void Count()
            {
                if (counting)
                {
                    textBox.Text += count.ToString() + ""; //вывод чисел
                    count++; //добавление значений
                    Application.Current.Dispatcher.InvokeAsync(Count, System.Windows.Threading.DispatcherPriority.Background); //вывод чисел в TextBox и его обновление
                }
            }
        }
    }
}
