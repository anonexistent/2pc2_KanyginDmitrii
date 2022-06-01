using System.Windows.Controls;

namespace exam
{
    internal class MyGroupBox : System.Windows.Controls.GroupBox
    {
        public MyGroupBox(string header)
        {
            this.Header = header;
            var a = new StackPanel();

            this.Content = a;

        }

    }
}
