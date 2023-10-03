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
    /// Interaction logic for Replacer.xaml
    /// </summary>
    public partial class Replacer : Window
    {
        public Replacer()
        {
            InitializeComponent();
        }

        public event EventHandler Next;
        public event EventHandler ReplaceWith;
        public event EventHandler ReplaceAll;

        private void FindNextBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.TextToFind = SearchText.Text;
            MainWindow.MatchCase = ChkMatchCase.IsChecked;
            MainWindow.WrapAround = ChkWraparound.IsChecked;

            MainWindow.UpWardDirection = false;
            MainWindow.DownWardDirection = true;
            Next?.Invoke(this, EventArgs.Empty);
        }

        private void replaceNextBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.TextToFind = SearchText.Text;
            MainWindow.TextToReplace = ReplaceText.Text;
            MainWindow.MatchCase = ChkMatchCase.IsChecked;
            MainWindow.WrapAround = ChkWraparound.IsChecked;

            MainWindow.UpWardDirection = false;
            MainWindow.DownWardDirection = true;
            ReplaceWith?.Invoke(this, EventArgs.Empty);
        }

        private void ReplaceAll_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.TextToFind = SearchText.Text;
            MainWindow.TextToReplace = ReplaceText.Text;
            MainWindow.MatchCase = ChkMatchCase.IsChecked;
            MainWindow.WrapAround = ChkWraparound.IsChecked;

            MainWindow.UpWardDirection = false;
            MainWindow.DownWardDirection = true;
            ReplaceAll?.Invoke(this, EventArgs.Empty);
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SearchText.Text = MainWindow.TextToFind;
            SearchText.Focus();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.ReplacerLoaded = false;
        }
    }
}
