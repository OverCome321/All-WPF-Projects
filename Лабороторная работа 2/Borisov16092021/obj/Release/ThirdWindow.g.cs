﻿#pragma checksum "..\..\ThirdWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6CDC103BBE7310D7A9AEE34352DCF227541FC6B7617B2FA0BE0A77AA6D6C47D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Borisov16092021;
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


namespace Borisov16092021 {
    
    
    /// <summary>
    /// ThirdWindow
    /// </summary>
    public partial class ThirdWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Click_Button;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Go_to_window1_Button;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ThirdWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Go_to_window2_Button_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Borisov16092021;component/thirdwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ThirdWindow.xaml"
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
            this.Click_Button = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\ThirdWindow.xaml"
            this.Click_Button.Click += new System.Windows.RoutedEventHandler(this.Click_Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Go_to_window1_Button = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ThirdWindow.xaml"
            this.Go_to_window1_Button.Click += new System.Windows.RoutedEventHandler(this.Go_to_window1_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Go_to_window2_Button_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ThirdWindow.xaml"
            this.Go_to_window2_Button_Copy.Click += new System.Windows.RoutedEventHandler(this.Go_to_window2_Button_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

