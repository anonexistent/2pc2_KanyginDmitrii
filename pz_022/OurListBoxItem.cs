using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media;
using System.Windows;
using System.Windows.Input;

namespace WpfA
{
    internal class OurListBoxItem : ListBoxItem
    {
        private string _OurFile;
        public string OurFile
        {
            get { return _OurFile; }
            set { _OurFile = value; }
        }
        public OurListBoxItem(string file0)
        {
            //Setter Property = "BorderThickness" Value = "2" />
  
            //  < Setter Property = "BorderBrush" Value = "Green" />
     
            //     < Setter Property = "Margin" Value = "1" />
        
            //        < Setter Property = "Cursor" Value = "Hand" />
            OurFile = file0;
            this.BorderThickness = new Thickness(2);
            this.BorderBrush = Brushes.Green;
            this.Margin = new Thickness(1);
            this.Cursor = Cursors.Hand;
            this.Content = System.IO.Path.GetFileName(file0);
        }



    }
}
