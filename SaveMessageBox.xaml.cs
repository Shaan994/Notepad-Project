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
    /// Interaction logic for SaveMessageBox.xaml
    /// </summary>
    public partial class SaveMessageBox : Window
    {
        public SaveMessageBox()
        {
            InitializeComponent();
        }

        private string message = "Do you want to save changes to Untitled?";
        private bool? result;

        public string Message { get => message; set => message = value; }
        public bool? Result { get => result; set => result = value; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowMessage.Text = Message;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Result = true;
            this.Close();
        }

        private void DontSavebtn_Click(object sender, RoutedEventArgs e)
        {
            Result = false;
            this.Close();
        }

        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            Result = null;
            this.Close();
        }
    }
}
