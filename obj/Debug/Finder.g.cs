﻿#pragma checksum "..\..\Finder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ABCFF2A7E6C4EB2FB5D3FF5194BF918306CB28A613D704DC556759070434753E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Notepad2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Notepad2 {
    
    
    /// <summary>
    /// Finder
    /// </summary>
    public partial class Finder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Finder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Finder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindNextBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Finder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancelbtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Finder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton UpRBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Finder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DownRBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Finder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkMatchCase;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Finder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkWrapAround;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Notepad2;component/finder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Finder.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\Finder.xaml"
            ((Notepad2.Finder)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Finder.xaml"
            ((Notepad2.Finder)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FindNextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Finder.xaml"
            this.FindNextBtn.Click += new System.Windows.RoutedEventHandler(this.FindNextBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cancelbtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Finder.xaml"
            this.Cancelbtn.Click += new System.Windows.RoutedEventHandler(this.Cancelbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpRBtn = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.DownRBtn = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.ChkMatchCase = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.ChkWrapAround = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
