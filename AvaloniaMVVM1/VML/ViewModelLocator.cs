﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;

namespace RSL.VML
{
    public /*static*/ class ViewModelLocator
    {
        public static bool GetAutoHookedUpViewModel(AvaloniaObject obj)
        {
            return (bool)obj.GetValue(AutoHookedUpViewModelProperty);
        }

        public static void SetAutoHookedUpViewModel(AvaloniaObject obj, bool value)
        {
            obj.SetValue(AutoHookedUpViewModelProperty, value);
        }

        // Using a DependencyProperty as the backing store for AutoHookedUpViewModel. 
        //This enables animation, styling, binding, etc...
        public static readonly AttachedProperty<bool> AutoHookedUpViewModelProperty =
            AvaloniaProperty.RegisterAttached<ViewModelLocator, Control, bool>("AutoHookedUpViewModel");

        static ViewModelLocator()
        {
            AutoHookedUpViewModelProperty
            .Changed
            .AddClassHandler<AvaloniaObject>(AutoHookedUpViewModelChanged);
        }
            
        //WPF comment
        /*
       public static readonly DependencyProperty AutoHookedUpViewModelProperty =
          DependencyProperty.RegisterAttached("AutoHookedUpViewModel",
          typeof(bool), typeof(ViewModelLocator), new
          PropertyMetadata(false, AutoHookedUpViewModelChanged));
        */

        private static void AutoHookedUpViewModelChanged(AvaloniaObject d, AvaloniaPropertyChangedEventArgs e)
        {
            //WPF comment
            //if (DesignerProperties.GetIsInDesignMode(d)) return;
            var viewType = d.GetType();

            string str = viewType.FullName;
            str = str.Replace(".Views.", ".ViewModels.");

            var viewTypeName = str;
            var viewModelTypeName = viewTypeName + "Model";
            var viewModelType = Type.GetType(viewModelTypeName);
            var viewModel = Activator.CreateInstance(viewModelType);

            ((Control)d).DataContext = viewModel;
        }

    }
}
