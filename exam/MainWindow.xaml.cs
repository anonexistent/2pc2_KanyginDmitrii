using System;
using System.Windows;
using System.Windows.Controls;

namespace exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            gbx0.Content = null;
            TextBlock a = new TextBlock();
            Button b = new Button();
            b.Content = "1234";
            a.Text = "testtesttest";
            a.FontWeight = FontWeights.Normal;

            StackPanel o = new StackPanel();

            o.Margin = new Thickness(5);
            o.Children.Add(a);
            o.Children.Add(b);

            a.Text = ex4.PrintTriangle(9);

            gbx0.Content = o;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //ex1
            gbx0.Content = null;

            double a = 8;
            double b = 2;

            gbx0.Content = new TextBlock() { Text = $"{Math.Log(a, b)}" };
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            gbx0.Content = null;

            TextBlock b = new TextBlock();

            ex2 a = new ex2();
            a.name = "dog";
            a.birth = new DateTime(2022, 01, 01);
            a.owner = "men";

            b.Text = a.name + " " + a.birth + " " + a.owner;
            gbx0.Content = b;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            gbx0.Content = new TextBlock() {Text = ex5.Go() };
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            gbx0.Content = new TextBlock(){Text = ex6.Go() };
        }
    }
}
