﻿#pragma checksum "..\..\Replacer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7119142C5E7AD8A8A64323BB9944DB81BDBD298F5CCCCD7DB0168C440ADD8E28"
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
    /// Replacer
    /// </summary>
    public partial class Replacer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindNextBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReplaceText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button replaceNextBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button replaceAllBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkMatchCase;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Replacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkWraparound;
        
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
            System.Uri resourceLocater = new System.Uri("/Notepad2;component/replacer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Replacer.xaml"
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
            
            #line 9 "..\..\Replacer.xaml"
            ((Notepad2.Replacer)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\Replacer.xaml"
            ((Notepad2.Replacer)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FindNextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Replacer.xaml"
            this.FindNextBtn.Click += new System.Windows.RoutedEventHandler(this.FindNextBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ReplaceText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.replaceNextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Replacer.xaml"
            this.replaceNextBtn.Click += new System.Windows.RoutedEventHandler(this.replaceNextBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.replaceAllBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Replacer.xaml"
            this.replaceAllBtn.Click += new System.Windows.RoutedEventHandler(this.ReplaceAll_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Replacer.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ChkMatchCase = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.ChkWraparound = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

