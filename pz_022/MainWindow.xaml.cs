using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

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
            lb0.ContextMenu.Background = Brushes.WhiteSmoke;
            rb0.ContextMenu.Background = Brushes.WhiteSmoke;
        }

        List<int> list0 = new List<int>();

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
            open.Filter = "TextFile (*.txt)|*.txt|RichTextFile (*.rtf)|*.rtf";
            open.ShowDialog();


            if (open.FileName.Length != 0)
            {
                rb0.Document.Blocks.Clear();

                if (open.FileName.Contains(".rtf"))
                {
                    RichBoxLoadRtf(rb0, open.FileName);
                }
                else
                {
                    StreamReader sr = new StreamReader(open.FileName);
                    rb0.AppendText(sr.ReadToEnd());
                    sr.Close();

                    //lb0.Items.Add($"{System.IO.Path.GetFileName(open.FileName)}");
                }
                OurListBoxItem our0 = new OurListBoxItem(System.IO.Path.GetFullPath(open.FileName));
                //our0.GotFocus += ListBoxItem_GotFocus;

                FileInfo fi = new FileInfo(open.FileName);

                lb0.Items.Add(our0);
                sbright.Text = (fi.Length).ToString() + " b";
            }
        }

        public void RichBoxLoadRtf(RichTextBox a, string filename)
        {
            var st = new MemoryStream(Encoding.Unicode.GetBytes(filename));
            FileStream ss = new FileStream(filename, FileMode.Open);
            a.Selection.Load(ss, DataFormats.Rtf);
            ss.Close();
            st.Close();
        }

        private void SaveFile(OurListBoxItem filename)
        {
            //////StreamWriter sw = new StreamWriter(filename.OurFile);            
            //////sw.Write(rb0.Document);
            //////sw.Close();

            //////StreamReader sr = new StreamReader(filename.OurFile);
            //////string filstr = sr.ReadToEnd();
            //////MemoryStream fs = new MemoryStream(ASCIIEncoding.Default.GetBytes(filstr));
            //////TextRange rg = new TextRange(rb0.Document.ContentStart, rb0.Document.ContentEnd);
            //////rg.Load(fs,DataFormats.Rtf);

            //////if(filename.OurFile.Contains(".rtf"))
            //////{
            //////    MemoryStream ms = new MemoryStream();
            //////    TextRange rg = new TextRange(rb0.Document.ContentStart,rb0.Document.ContentEnd);
            //////    rg.Save(ms,DataFormats.Rtf);
            //////    ms.Seek(0, SeekOrigin.Begin);

            //////}

            //var str = new FlowDocument();
            //str = rb0.Document;
            //var sw = new StreamWriter(filename.OurFile);
            //sw.Write(DataFormats.Rtf, str);
            //sw.Close();

            //TextRange rg = new TextRange(rb0.Document.ContentStart,rb0.Document.ContentEnd);
            //StreamWriter sw = new StreamWriter(filename.OurFile);
            //sw.Write(rg.ToString());
            //sw.Close();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TextFile (*.txt)|*.txt";
            save.ShowDialog();

            try
            {
                string filename0 = save.FileName;
                TextRange rg = new TextRange(rb0.Document.ContentStart, rb0.Document.ContentEnd);
                FileStream fs = new FileStream(filename0, FileMode.OpenOrCreate);
                rg.Save(fs, DataFormats.Text);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message.ToUpper()}", "eror", MessageBoxButton.YesNoCancel);
            }
        }

        private void MenuItem_Create_Click(object sender, RoutedEventArgs e) => CreateFile("wht.txt");  //menu create

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e) => OpenFile();   //file open

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            lb0.Items.RemoveAt(lb0.Items.Count - 1);   //contex listbox
            rb0.Document.Blocks.Clear();
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
            try
            {
                SaveFile((OurListBoxItem)lb0.Items[lb0.Items.Count - 1]);
            }
            catch (Exception)
            {
                MessageBox.Show("eror", "eror", MessageBoxButton.YesNoCancel);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            stackpanel0.IsEnabled = false;
            button007.Visibility = Visibility.Visible;
            lb0.IsEnabled = false;
            rb0.IsEnabled = false;
            popup1.IsOpen = true;

            //statusbar0.Items.Clear();
            //TextBox tempTextBox = new TextBox();
            //ComboBox tempComboBox = new ComboBox();
            ComboBoxItem item = new ComboBoxItem();
            item.Content = ".txt";
            tempcombox0.Items.Add(item);
            item = (ComboBoxItem)tempcombox0.Items[0];
            item.IsSelected = true;
            //tempTextBox.Width = 100;
            //tempComboBox.Width = 50;
            //tempComboBox.Margin = new Thickness(100);
            //statusbar0.Items.Add(tempTextBox);
            //statusbar0.Items.Add(tempComboBox);

            //statusbar0.IsEnabled= true;

            tempcombox0.Visibility = Visibility.Visible;
            temptextbox0.Visibility = Visibility.Visible;
            butbut.Click += But_click;
        }
        private void But_click(object sender, RoutedEventArgs e)
        {
            string filelll = temptextbox0.Text;
            stackpanel0.IsEnabled = true;
            button007.Visibility = Visibility.Hidden;
            lb0.IsEnabled = true;
            rb0.IsEnabled = true;
            popup1.IsOpen = false;
            tempcombox0.Visibility = Visibility.Hidden;
            temptextbox0.Visibility = Visibility.Hidden;


            FileStream fs = new FileStream(@"..\data\" + filelll + @".txt", FileMode.CreateNew);
            fs.Close();

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("gfdfg");
        }

        //  Паттерн "Команда" (Command)


    }
}
