using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad2
{
    public class NotepadCommands
    {
        private static readonly RoutedUICommand newWindow;
        private static readonly RoutedUICommand saveAs;

        // defining the command object for SearchWithbing
        private static readonly RoutedUICommand searchWithBing;

        // defining the command object for FindNext
        private static readonly RoutedUICommand findNext;

        // defining the command object for FindPrevious
        private static readonly RoutedUICommand findPrevious;

        // defining the command object for Go To
        private static readonly RoutedUICommand goTo;

        // defining the command object for Time/Date
        private static readonly RoutedUICommand time_Date;
        static NotepadCommands()
        {
            // defining the commands 
            InputGestureCollection newWindowGestures = new InputGestureCollection
            {
                //reating the KeyGestrues for Open new Window commands
                new KeyGesture(Key.N, ModifierKeys.Control | ModifierKeys.Shift, "Ctrl+Shift+N")
            };

            newWindow = new RoutedUICommand("New Window", "NewWindow", typeof(NotepadCommands), newWindowGestures);

            #region SaveCommand Initialization
            //Save Command Initialization
            saveAs = new RoutedUICommand
                (
                "SaveAs", 
                "SaveAs", 
                typeof(NotepadCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.S, ModifierKeys.Control | ModifierKeys.Shift, "Ctrl+Shift+S")
                }
                );
            #endregion

            #region SearchWithBing Initialization

            // Initialization of SearchWithBing command
            searchWithBing = new RoutedUICommand
                (
                "Search With Bing", 
                "SearchWithBing", 
                typeof(NotepadCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.E, ModifierKeys.Control , "Ctrl+E")
                }
                );

            #endregion

            #region FindNext Initialization

            // Initialization of FindNext command
            findNext = new RoutedUICommand
                (
                "Find Next...",
                "FindNext",
                typeof(NotepadCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.F3, ModifierKeys.None , "F3")
                }
                );

            #endregion

            #region FindPrevious Initialization

            // Initialization of FindPrevious command
            findPrevious = new RoutedUICommand
                (
                "Find Previous...",
                "FindPrevious",
                typeof(NotepadCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.F3, ModifierKeys.Shift , "Shift+F3")
                }
                );

            #endregion

            #region GoTo Initialization

            // Initialization of GoTo command
            goTo = new RoutedUICommand
                (
                "Go To...",
                "GoTo",
                typeof(NotepadCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.G, ModifierKeys.Control , "Ctrl+G")
                }
                );

            #endregion

            #region TimeDate Initialization

            // Initialization of TimeDate command
            time_Date = new RoutedUICommand
                (
                "Time/Date",
                "TimeDate",
                typeof(NotepadCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.F5, ModifierKeys.None , "F5")
                }
                );

            #endregion

        }

        //Wrapper for the newWindow command
        public static RoutedUICommand NewWindow
        {
            get { return newWindow; }
        }

        //Wrapper for the SaveAs command
        public static RoutedUICommand SaveAs
        {
            get { return saveAs; }
        }

        //Wrapper for the SearchWithBing command
        public static RoutedUICommand SearchWithBing
        {
            get { return searchWithBing; }
        }


        //Wrapper for the FindNext command
        public static RoutedUICommand FindNext
        {
            get { return findNext; }
        }

        //Wrapper for the FindPrevious command
        public static RoutedUICommand FindPrevious
        {
            get { return findPrevious; }
        }

        //Wrapper for the GoTo command
        public static RoutedUICommand GoTo
        {
            get { return goTo; }
        }

        //Wrapper for the TimeDate command
        public static RoutedUICommand TimeDate
        {
            get { return time_Date; }
        }

    }
}
