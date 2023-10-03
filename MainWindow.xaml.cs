using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Notepad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // some imporatant varaibles to hold the information about the loaded file
        private string fileName = "Untitled"; // will hold the name of the loaded file
        private string filePath = "";
        private string fileData = "";
        private bool shouldSave = false; // will hold the Save status of the file

        public string FileName { get => fileName; set => fileName = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public string FileData { get => fileData; set => fileData = value; }
        public bool ShouldSave { get => shouldSave; set => shouldSave = value; }


        #region Commands of the Application
        private void Reset()
        {
            // Reset the Filename to Untitled and related data as well
            FileName = "Untitled";
            FilePath = FileData = "";
            // Rese the ShouldSave varaible
            ShouldSave = false;

            // also reset the TextArea 
            TextArea.Text = "";
            this.Title = FileName + " - Notepad";
        }

        private bool? AskToSavetheFile()
        {
            // creating an object of custom messagebox
            SaveMessageBox asktoSave = new SaveMessageBox();
            // then check whether the FilePath is Exists or not
            if (System.IO.File.Exists(FilePath))
            {
                asktoSave.Message = "Do you want to save changes to " + FilePath + "?";
            }
            else
            {
                asktoSave.Message = "Do you want to save changes to " + FileName + "?";
            }
           
            asktoSave.Owner = this;
            asktoSave.ShowDialog();
            return asktoSave.Result;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // when user clicks the newCommand 
            // then first check whether the file should save of not
            if(ShouldSave)
            {
                // then call to Show Message Box
                bool? r = AskToSavetheFile();
                // if user wnats to save the file
                if (r == true)
                {
                    // then check whether the FilePath is Exists or not
                    if (System.IO.File.Exists(FilePath))
                    {
                        // Direct save 
                        DirectSave();
                        Reset();
                    }
                    else
                    {
                      bool? b =  SaveAsFile();
                        // if user saved the file
                        if (b == true)
                            Reset();// after that reset everything. 
                    }
                }
                else if (r == false)
                    Reset();
            }
            else
            {
                Reset();
            }
        }

        private void NewWindowCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // load another instance of the current process
            Process.Start(Process.GetCurrentProcess().MainModule.FileName);

        }

        //LoadNewFile() method will opne the OpenFileDialog for the user 
        // so that he/she can easily select and open the file
        private void LoadNewFile()
        {
            // first create an object of OpenFileDiloag
            OpenFileDialog OpenNewFile = new OpenFileDialog();
            // Set some settings fo the object
            OpenNewFile.Title = "Open";
            OpenNewFile.DefaultExt = ".txt";
            OpenNewFile.Filter = "Text Document (.txt)|*.txt|All Files (*.*)|*.*";
            OpenNewFile.InitialDirectory = "Document";
            OpenNewFile.RestoreDirectory = true;

            // Saving the FileDailog return results
            bool? result = OpenNewFile.ShowDialog();

            // if user clicks any file or wants to open any file
            if(result == true)
            {
                // the first take the FilePath from OpenfileDialog object
                FilePath = OpenNewFile.FileName;
                // and now take the file name without file extension
                FileName = System.IO.Path.GetFileNameWithoutExtension(FilePath);
                // now extract the Data from file
                FileData = System.IO.File.ReadAllText(FilePath);

                // now set the title of application and textarea of application according 
                // to user selection file
                this.Title = FileName + " - Notepad";
                TextArea.Text = FileData;
                ShouldSave = false;
            }
        }

        // when user clicks the Open command (Ctrl+O)
        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // then first check that the current data on the TextArea should be saved or not
            if (ShouldSave == true)
            {
                // then call to Show Message Box
                bool? r = AskToSavetheFile();
                // if user wnats to save the file
                if (r == true)
                {
                    // then check whether the FilePath is Exists or not
                    if (System.IO.File.Exists(FilePath))
                    {
                        // Direct save 
                        DirectSave();
                        LoadNewFile();
                    }
                    else
                    {
                        bool? b = SaveAsFile();
                        // if user saved the file
                        if (b == true)
                            LoadNewFile();
                    }
                }
                else if (r == false)
                    LoadNewFile();
            }
            else
                LoadNewFile();
        }

        // DirectSave() method will savve the file Directly
        // means without opening of SaveFileDailog
        private void DirectSave()
        {
            // just WriteAllText to Filepath
            System.IO.File.WriteAllText(FilePath, TextArea.Text);
            // and also the FileData should be reset.
            FileData = TextArea.Text;
            ShouldSave = false;
            this.Title = FileName + " - Notepad";
        }

        // when user clicks the Save menu item to save the work
        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // then check whether the FilePath is Exists or not
            if (System.IO.File.Exists(FilePath))
            {
                // Direct save 
                DirectSave();
            }
            else
            {
                SaveAsFile();
            }
        }

        //SaveAsFile() method will open SaveFileDailog for the user to save the data to file
        // this method also return the Saving status of user
        private bool? SaveAsFile()
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            // setting the Filsters, Title, DefaultText, InitialDirectory
            SaveFile.Title = "Save As";
            SaveFile.Filter = "Text Document (.txt)|*.txt|All Files (*.*)|*.*";
            SaveFile.InitialDirectory = "Document";
            SaveFile.RestoreDirectory = true;

            // Saving the FileDialog results
            bool? b = SaveFile.ShowDialog();
            if (b == true) // if user realy saved the file with appropriate filepath.
            {
                // the first take the FilePath from SaveFileDialog object
                FilePath = SaveFile.FileName;
                // and now take the file name without file extension
                FileName = System.IO.Path.GetFileNameWithoutExtension(FilePath);
                // now extract the Data from file
                System.IO.File.WriteAllText(FilePath, TextArea.Text);

                // now set the title of application and textarea of application according 
                // to user selection file
                this.Title = FileName + " - Notepad";
                FileData = TextArea.Text;
                ShouldSave = false;
                return true;

            }
            return b;

        }

        private void SaveAsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveAsFile();
        }

        #region "PageSetup and Print Menuitem
        private void PageSetup_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.PageSetupDialog PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();

            PageSetupDialog1.AllowMargins = true;
            PageSetupDialog1.AllowOrientation = true;
            PageSetupDialog1.AllowPaper = true;
            PageSetupDialog1.AllowPrinter = true;

            // define page Settings for pageSetupDialog1
            PageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();

            // Define printer settings for PageSetupDialog1
            PageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();

            PageSetupDialog1.ShowDialog();

        }

        private void PrintCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // show the PrintDailog
            PrintDialog printDialog = new PrintDialog();
            if(printDialog.ShowDialog() == true)
            {
                // to print the Data as PDf or Hard Form
                FlowDocument flowDocument = new FlowDocument();
                flowDocument.PagePadding = new Thickness(50);
                flowDocument.Blocks.Add(new Paragraph(new Run(TextArea.Text)));

                printDialog.PrintDocument((((IDocumentPaginatorSource)flowDocument).DocumentPaginator), "UsingPaginator");
            }

        }
        #endregion


        #region Delete Command CanExecuted and Executed
        private void DeleteCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            if (TextArea.SelectedText.Length > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextArea.SelectedText = "";
        }

        #endregion

        private void SearchWithBingCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Search in the Default browser
            Process.Start("https://www.bing.com/Search?q=" + TextArea.SelectedText);
            // to open something in Microsoft-Edge use below code
            //Process.Start("microsoft-edge:https://www.bing.com/Search?q=" + TextArea.SelectedText);
        }


        #region "Find Command CanExecuted and Executed Events"
        public static bool FinderLoaded = false;
        private void FindCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            if (TextArea.Text.Length > 0 && ReplacerLoaded == false)
                e.CanExecute = true;
            else if (TextArea.Text.Length > 0 && ReplacerLoaded == true)
                e.CanExecute = false;
        }
        private void FindCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // when ever the click the Find Button
            // Create an object o Finder class
            Finder finder = new Finder();
            finder.Owner = this;
            finder.Next += OnNext_Click;
            isFinderFirstTimeLoad = true;
            TextToFind = TextArea.SelectedText;
            FinderLoaded = true;
            finder.Show();
        }

        public static string TextToFind = "";
        public static string TextToReplace = "";
        public static bool? MatchCase = false;
        public static bool? WrapAround = false;
        public static bool? UpWardDirection = true;
        public static bool? DownWardDirection = false;

        Regex regex; // will hold teh regular expression pattern
        Match match; // will hold the Match result of Regex. 
        bool isFinderFirstTimeLoad = false;


        private void GetRegex()
        {
            // if the MatchCase is On
            if (MatchCase == true)
            {
                // then first check whether the user watns to search right to left or left to right
                if (UpWardDirection == true)
                    regex = new Regex(TextToFind, RegexOptions.RightToLeft);
                else if (DownWardDirection == true)
                    regex = new Regex(TextToFind);
            }
            else
            {
                // then first check whether the user watns to search right to left or left to right
                if (UpWardDirection == true)
                    regex = new Regex(TextToFind, RegexOptions.RightToLeft | RegexOptions.IgnoreCase);
                else if (DownWardDirection == true)
                    regex = new Regex(TextToFind, RegexOptions.IgnoreCase);
            }
        }

        private void OnNext_Click(object sender, EventArgs e)
        {
            // Check that whether the Finder is loaded first time or not
            if(isFinderFirstTimeLoad)
            {
                GetRegex();

                // get the First match from TextArea.Text property
                match = regex.Match(TextArea.Text);
                isFinderFirstTimeLoad = false;
            }
            else
            {
                GetRegex();

                // get the First match from TextArea.Text property
                match = regex.Match(TextArea.Text, match.Index + 1);
            }

            // if the match is found
            if(match.Success)
            {
                // then select the match from textArea
                TextArea.Focus();
                TextArea.Select(match.Index, match.Length);
            }
            else
            {
                // then show the messageBox.
                if (WrapAround == true)
                {
                    isFinderFirstTimeLoad = true;
                    OnNext_Click(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show(String.Format("Cannot find '{0}'", TextToFind), "Notepad", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }


        }
        #endregion

        private void ReplaceCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            if (TextArea.Text.Length > 0 && FinderLoaded == false)
                e.CanExecute = true;
            else if (TextArea.Text.Length > 0 && FinderLoaded == true)
                e.CanExecute = false;
        }

        public static bool ReplacerLoaded = false;
        private void ReplaceCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Create the object of Replacer
            Replacer replace = new Replacer();
            // Set the owner of the object
            replace.Owner = this;
            isFinderFirstTimeLoad = true;

            // connect the Event handlers
            replace.Next += OnNext_Click;
            replace.ReplaceWith += ReplaceWith_Click;
            replace.ReplaceAll += ReplaceAll_Click;
            ReplacerLoaded = true;

            replace.Show();
        }

        private void ReplaceAll_Click(object sender, EventArgs e)
        {
            GetRegex();

            // now create new string by replacing all instances 
            string newString = regex.Replace(TextArea.Text, TextToReplace);
            TextArea.Text = newString;
        }

        private void ReplaceWith_Click(object sender, EventArgs e)
        {
            if (TextArea.SelectedText.Length > 0 && TextToReplace.Length > 0)
                TextArea.SelectedText = TextToReplace;
        }

        #region FindNextCommand Canexecuted and Executed

        private void FindNextCommand_CanExected(object sender, CanExecuteRoutedEventArgs e)
        {
            if (TextToFind.Length > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }
        private void FindNextCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DownWardDirection = true;
            UpWardDirection = false;
            WrapAround = true;
            OnNext_Click(this, EventArgs.Empty);
        }
        #endregion

        private void FindPreviousCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DownWardDirection = false;
            UpWardDirection = true;
            WrapAround = true;
            OnNext_Click(this, EventArgs.Empty);
        }

        private void GoToCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GoTo goTo = new GoTo();
            goTo.Owner = this;
            goTo.TotalLineNumber = TextArea.LineCount;
            goTo.ShowDialog();
            TextArea.ScrollToLine(goTo.LineNumber);
        }

        private void TimeDateCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (TextArea.SelectedText.Length > 0)
                TextArea.SelectedText = DateTime.Now.ToString("h:mm tt dddd - MM/dd/yyyy");
            else
                TextArea.Text += DateTime.Now.ToString("h:mm tt dddd - MM/dd/yyyy");

        }

        #endregion

        private int currentLine = 0;
        private int currentColum = 0;
        private void TextArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            // if the TextArea's Text is equal to Old File Data
            if(TextArea.Text == FileData)
            {
                this.Title =  FileName + " - Notepad";
                ShouldSave = false;
            }
             else
            {
                this.Title = "*" + FileName + " - Notepad";
                ShouldSave = true;
            }

            currentLine = TextArea.GetLineIndexFromCharacterIndex(TextArea.CaretIndex);
            currentColum = TextArea.CaretIndex;
            currentLine += 1;
            currentColum += 1;

            CaretLocationStatus.Content = "Ln " + currentLine + ", Col " + currentColum;
        }

        #region All Closing of Application 
        private bool ShouldClose()
        {
            if (ShouldSave)
            {
                // then call to Show Message Box
                bool? r = AskToSavetheFile();
                // if user wnats to save the file
                if (r == true)
                {
                    // then check whether the FilePath is Exists or not
                    if (System.IO.File.Exists(FilePath))
                    {
                        // Direct save 
                        DirectSave();
                        return true;
                    }
                    else
                    {
                        bool? b = SaveAsFile();
                        // if user saved the file
                        if (b == false || b == null)
                            return false;
                    }
                }
                else if (r == false)
                    return true;
                else
                    return false;
            }

            return true;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ShouldClose() == false)
                e.Cancel = true;
        }
        #endregion

        #region Word Wrap MenuItem
        private void WordWrapMenuitem_Checked(object sender, RoutedEventArgs e)
        {
            TextArea.TextWrapping = TextWrapping.WrapWithOverflow;
            TextArea.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
        }

        private void WordWrapMenuitem_Unchecked(object sender, RoutedEventArgs e)
        {
            TextArea.TextWrapping = TextWrapping.NoWrap;
            TextArea.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
        }
        #endregion

        private void FontMenuitem_Click(object sender, RoutedEventArgs e)
        {
            // show the FontDialog
            System.Windows.Forms.FontDialog FD = new System.Windows.Forms.FontDialog();

            // first take the FontName from TextArea
            string FontName = TextArea.FontFamily.ToString();
            // and create the Font object from TextArea
            System.Drawing.Font f = new System.Drawing.Font(FontName, float.Parse(TextArea.FontSize.ToString()));
            FD.ShowEffects = false;

            FD.Font = f;

            // show the Dialog and if the user clicked Ok Button
            if(FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // then From the user selected options
                // change the TextArea's FontFamily and FontSize and also other properties
                TextArea.FontFamily = new System.Windows.Media.FontFamily(FD.Font.Name);
                TextArea.FontSize = FD.Font.Size;
                TextArea.FontStyle = FD.Font.Italic ? FontStyles.Italic : FontStyles.Normal;
                TextArea.FontWeight = FD.Font.Bold ? FontWeights.Bold : FontWeights.Normal;

            }
           
        }

        #region StatusBar menu item
        private void StatusbarMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if (NotepadStatusBar.Visibility != Visibility.Visible)
                NotepadStatusBar.Visibility = Visibility.Visible;
        }

        private void StatusbarMenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
                NotepadStatusBar.Visibility = Visibility.Collapsed;
        }
        #endregion


        #region Right To Left Context (Menu Item)

        private void RightToLeftMenuitem_Checked(object sender, RoutedEventArgs e)
        {
            TextArea.FlowDirection = FlowDirection.RightToLeft;
            CustomContextMenu.FlowDirection = FlowDirection.LeftToRight;
        }

        private void RightToLeftMenuitem_Unchecked(object sender, RoutedEventArgs e)
        {
            TextArea.FlowDirection = FlowDirection.LeftToRight;
            CustomContextMenu.FlowDirection = FlowDirection.LeftToRight;
        }
        #endregion

        #region About Menuitem
        private void ViewMenuitem_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.bing.com/Search?q=" + "get help with notepad in windows");
        }

        private void SendFeedbackMenuitem_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.bing.com/Search?q=" + "Open FeedBack-Hub and send Feedback");
        }

        private void AboutNotepd_click(object sender, RoutedEventArgs e)
        {
            AboutNotepad AN = new AboutNotepad();
            AN.Owner = this;
            AN.ShowDialog();
        }





        #endregion


    }
}
