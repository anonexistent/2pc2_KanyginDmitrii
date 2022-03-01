using System;
using System.Diagnostics;
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
using System.Net;

namespace pz_021
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

        private void button_result_Click(object sender, RoutedEventArgs e)
        {
            //берем из тб_резалт строку и меняем текст в тб на конечный результат
        }

        private void button_1x_Click(object sender, RoutedEventArgs e)
        {
            if (tb_result!=null) tb_result.Text = $"1 / {tb_result.Text}";
        }

        private void button_x2_Click(object sender, RoutedEventArgs e)
        {
            //double time1 = 0;
            //double.TryParse(string.Join("", tb_result.Text.Where(w => char.IsDigit(w))), out time1);
            //tb_result.Text = Math.Pow(time1, 2).ToString();
        }

        private void button_sqrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_proc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_umnojit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_delit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button00_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '0';
        }

        private void button01_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '1';
        }

        private void button02_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '2';
        }

        private void button03_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '3';
        }

        private void button04_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '4';
        }

        private void butto05_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '5';
        }

        private void button06_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '6';
        }

        private void button07_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '7';
        }

        private void button08_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '8';
        }

        private void button09_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text += '9';
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Back:
                    if (tb_result.Text.Length != 0) tb_result.Text = tb_result.Text.Substring(0, tb_result.Text.Length - 1);
                    break;
                case Key.Enter:
                    //должен делать тоже самое тчо button_result_Click
                    break;
                case Key.Escape:
                    //может быть выход 
                    break;
            
                case Key.NumPad0:
                    //тоже самое что button00_Click
                    tb_result.Text += 0;
                    break;
                case Key.NumPad1:
                    tb_result.Text += 1;
                    break;
                case Key.NumPad2:
                    tb_result.Text += 2;
                    break;
                case Key.NumPad3:
                    tb_result.Text += 3;
                    break;
                case Key.NumPad4:
                    tb_result.Text += 4;
                    break;
                case Key.NumPad5:
                    tb_result.Text += 5;
                    break;
                case Key.NumPad6:
                    tb_result.Text += 6;
                    break;
                case Key.NumPad7:
                    tb_result.Text += 7;
                    break;
                case Key.NumPad8:
                    tb_result.Text += 8;
                    break;
                case Key.NumPad9:
                    tb_result.Text += 9;
                    break;

                case Key.OemTilde:
                    //ждем версии 2.0
                    break;
            
                default:
                    //ждем версии 2.0
                    //for (int i = 0; i < 20; i++) Process.Start("explorer");
                    //Process.GetProcessById(6992).Kill();
                    //    WebBrowser webBrowser1 = new WebBrowser();
                    //    webBrowser1.
                    //    webBrowser1.Navigate("http://multmult.ru/admitad-banner.html");
                    break;
            }
        }
    }
}
