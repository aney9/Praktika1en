﻿#pragma checksum "..\..\vtoroe.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F00FEF383472C03F2572A97E7A3B47B0FAB33F868AD07C431B9BE316D2DA8C53"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using praktika1en;


namespace praktika1en {
    
    
    /// <summary>
    /// vtoroe
    /// </summary>
    public partial class vtoroe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\vtoroe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg2;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\vtoroe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sekt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\vtoroe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ryad;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\vtoroe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mestoo;
        
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
            System.Uri resourceLocater = new System.Uri("/praktika1en;component/vtoroe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\vtoroe.xaml"
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
            this.dg2 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\vtoroe.xaml"
            this.dg2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg2_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\vtoroe.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cl2);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\vtoroe.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cl1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\vtoroe.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cl3);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\vtoroe.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cl4);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sekt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ryad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.mestoo = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

