using System;
using System.IO;
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
using Microsoft.Win32;

namespace WpfA
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

        int[] qq = { 1, 2, 3, 4, 5 };

        public void CreateFile(string filename)
        {
            string path0 = @"..\data\" + filename;
            StreamWriter sw = new StreamWriter(path0);
            sw.Write(qq);
            sw.Close();
            lb0.Items.Add($"{System.IO.Path.GetFileName(filename)}");

            

            //using (FileStream fs = new FileStream(path0, FileMode.Create)) 
            //{

            //    sw.Write(qq);
            //}
        }

        public void OpenFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            
            open.Filter = "TextFile (*.txt)|*.txt|RichTextFile (*.rtf)|*.rtf";
            open.ShowDialog();
            StreamReader sr = new StreamReader(open.FileName);
            rb0.AppendText(sr.ReadToEnd());
            sr.Close();
            lb0.Items.Add($"{System.IO.Path.GetFileName(open.FileName)}");
            
        }

        public void AddListBoxItem() 
        {
            //if(! rb0.Document.GetValue)
        }

        public void SaveFile(string filename)
        {

        }


        private void MenuItem_Create_Click(object sender, RoutedEventArgs e)
        {
            CreateFile("a11c.txt");

        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            lb0.Items.Add("1");
        }
    }
}
