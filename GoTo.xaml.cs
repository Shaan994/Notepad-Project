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
using System.Windows.Shapes;

namespace Notepad2
{
    /// <summary>
    /// Interaction logic for GoTo.xaml
    /// </summary>
    public partial class GoTo : Window
    {
        public GoTo()
        {
            InitializeComponent();
        }

        private int lineNumber = 0;
        private int totalLineNumber = 0;

        public int LineNumber { get => lineNumber; set => lineNumber = value; }
        public int TotalLineNumber { get => totalLineNumber; set => totalLineNumber = value; }

        private void Okbtn_Click(object sender, RoutedEventArgs e)
        {
            LineNumber = Int32.Parse(LineNumberToGo.Text);

            if(LineNumber<=TotalLineNumber)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("The line number is beyond the total number of lines", "Go To", MessageBoxButton.OK);
            }
        }

        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LineNumberToGo.Text = TotalLineNumber.ToString();
            LineNumberToGo.Focus();
        }
    }
}
