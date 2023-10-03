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
    /// Interaction logic for Finder.xaml
    /// </summary>
    public partial class Finder : Window
    {
        public Finder()
        {
            InitializeComponent();
        }
        // When user press the NextButton then we fire this EventHandler
        public event EventHandler Next;


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SearchText.Text = MainWindow.TextToFind;
            SearchText.Focus();
        }

        private void FindNextBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.TextToFind = SearchText.Text;
            MainWindow.MatchCase = ChkMatchCase.IsChecked;
            MainWindow.WrapAround = ChkWrapAround.IsChecked;

            MainWindow.UpWardDirection = UpRBtn.IsChecked;
            MainWindow.DownWardDirection = DownRBtn.IsChecked;
            Next?.Invoke(this, EventArgs.Empty);
        }

        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.FinderLoaded = false;
        }
    }
}
