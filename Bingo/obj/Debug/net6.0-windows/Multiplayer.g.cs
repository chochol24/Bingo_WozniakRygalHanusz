﻿#pragma checksum "..\..\..\Multiplayer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DEEB4C91117307CC9E1E64DD48E6EEC774D81115"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Bingo;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Bingo {
    
    
    /// <summary>
    /// Multiplayer
    /// </summary>
    public partial class Multiplayer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Serwer;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Klient;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox daneIP;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIPserw;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstGameType;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstBoardSize;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstCategory;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Multiplayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bingo;component/multiplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Multiplayer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Serwer = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Multiplayer.xaml"
            this.Serwer.Click += new System.Windows.RoutedEventHandler(this.Serwer_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Klient = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Multiplayer.xaml"
            this.Klient.Click += new System.Windows.RoutedEventHandler(this.Klient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.daneIP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtIPserw = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lstGameType = ((System.Windows.Controls.ListBox)(target));
            
            #line 16 "..\..\..\Multiplayer.xaml"
            this.lstGameType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstGameType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstBoardSize = ((System.Windows.Controls.ListBox)(target));
            
            #line 17 "..\..\..\Multiplayer.xaml"
            this.lstBoardSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstBoardSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lstCategory = ((System.Windows.Controls.ListBox)(target));
            
            #line 18 "..\..\..\Multiplayer.xaml"
            this.lstCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Multiplayer.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

