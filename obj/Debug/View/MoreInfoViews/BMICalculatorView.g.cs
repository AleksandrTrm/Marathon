﻿#pragma checksum "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76377C0F949EEC0E45EEF820997ED6C94F398795FD0682FDD9DD3D217A293F70"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Marathone.Styles.Converters;
using Marathone.View.MoreInfoViews;
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


namespace Marathone.View.MoreInfoViews {
    
    
    /// <summary>
    /// BMICalculatorView
    /// </summary>
    public partial class BMICalculatorView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ManButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton WomanButton;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeightValue;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WeightValue;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image HumanStateImage;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HumanState;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas ArrowField;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Triangle;
        
        #line default
        #line hidden
        
        
        #line 228 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label IndexResult;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RectangleGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Maraphone;component/view/moreinfoviews/bmicalculatorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
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
            this.ManButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 53 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
            this.ManButton.IsEnabledChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.ManButton_OnIsEnabledChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WomanButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 67 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
            this.WomanButton.IsEnabledChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.WomanButton_OnIsEnabledChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HeightValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.WeightValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 140 "..\..\..\..\View\MoreInfoViews\BMICalculatorView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HumanStateImage = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.HumanState = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ArrowField = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.Triangle = ((System.Windows.Shapes.Path)(target));
            return;
            case 10:
            this.IndexResult = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.RectangleGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
