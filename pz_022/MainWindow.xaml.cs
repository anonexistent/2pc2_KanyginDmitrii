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

        List<string> list0 = new List<string>();

        private string _ffile;
        public string ffile
        {
            get { return _ffile = "a11c.txt"; }
        }


        public void CreateFile(string filename)
        {
            string path0 = @"..\data\" + filename;
            StreamWriter sw = new StreamWriter(path0);
            sw.Write("1,2,3,4,5");
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
            open.ShowDialog();
            open.Filter = "TextFile (*.txt)|*.txt|RichTextFile (*.rtf)|*.rtf";            
            
            if (open.FileName.Length!=0)
            {
                rb0.Document.Blocks.Clear();
                StreamReader sr = new StreamReader(open.FileName); 
                rb0.AppendText(sr.ReadToEnd());
                sr.Close();

                //lb0.Items.Add($"{System.IO.Path.GetFileName(open.FileName)}");

                OurListBoxItem our0 = new OurListBoxItem(System.IO.Path.GetFileName(open.FileName));

                lb0.Items.Add(our0);
            }
        }

        public void SaveFile(string filename)
        {
            
            
        }


        private void MenuItem_Create_Click(object sender, RoutedEventArgs e)
        {
            //menu create
            CreateFile("wht.txt");
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            //file open
            OpenFile();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            //button0000000
            lb0.Items.Add("1");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //contex listbox
            lb0.Items.RemoveAt(lb0.Items.Count - 1);

        }

        private void lb0_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (lb0.Items.Count > 1) cm0delete.IsEnabled = true;
            else cm0delete.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //FontFamily family = new FontFamily();
            //family = FontFamily.FamilyNames.;
            //rb0.FontFamily;

            if (rb0.FontStyle != FontStyles.Italic) rb0.FontStyle = FontStyles.Italic;
            else rb0.FontStyle = FontStyles.Normal;

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //button save

            
        }
    }
}
