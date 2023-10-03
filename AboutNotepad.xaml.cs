using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AboutNotepad.xaml
    /// </summary>
    public partial class AboutNotepad : Window
    {
        public AboutNotepad()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserName.Content = "to: " + Environment.UserName;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://support.microsoft.com/en-us/windows/microsoft-software-license-terms-e26eedad-97a2-5250-2670-aad156b654bd");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
