﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RSL.Analysis;

namespace RSL.Graphics.Generation.Analysis
{
    /// <summary>
    /// Логика взаимодействия для AnalyzerDevationCenterXControl.xaml
    /// </summary>
    public partial class AnalyzerDevationCenterXControl : UserControl, IAnalyzerControl
    {
        public AnalyzerDevationCenterXControl()
        {
            InitializeComponent();
        }

        public IAnalyzer Generate()
        {
            return new AnalyzerDevationCenterX();
        }
    }
}
